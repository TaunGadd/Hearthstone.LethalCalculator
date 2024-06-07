using Hearthstone.LethalCalculator.Models.Domain;
using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Domain.Characters;
using Hearthstone.LethalCalculator.Service.Interfaces;

namespace Hearthstone.LethalCalculator.Service;

public class LethalCalculatorService : ILethalCalculatorService
{
    public bool IsLethal(GameState gamestate)
    {
        var totalDamage = gamestate.Self.Weapon.Damage + 
            gamestate.MyMinions
            .Select(x => x.Damage)
            .Sum();

        var tauntOpponents = gamestate.OpponentMinions
            .Count(x => x.Passives.Select(y => y.Name).Contains(nameof(Taunt)));

        // Quickly covering the case of no taunt minions
        if (tauntOpponents == 0 && totalDamage >= gamestate.Opponent.CurrentHealth + gamestate.Opponent.Armour)
        {
            return true;
        }

        // TODO: need to determine if there are minions left that haven't attacked, and if so, does their attack beat the enemy's hp?
        var optimalAttackPattern = FindOptimalAttackPattern(gamestate);

        return false;
    }

    private Dictionary<Minion, Minion[]> FindOptimalAttackPattern(GameState gamestate)
    {
        var optimalAttackedByPattern = new Dictionary<Minion, Minion[]>();

        var enemiesWithTaunt = gamestate.OpponentMinions
            .Where(x => x.Passives.Select(y => y.Name)
            .Contains(nameof(Taunt)));

        var myMinionsSimulation = gamestate.MyMinions.Select(x => x.DeepCopy());
        var enemiesSimulation = enemiesWithTaunt.Select(x => x.DeepCopy());

        foreach (Minion enemy in enemiesSimulation)
        {
            var used = new bool[enemiesSimulation.Count()];
            var bestPairing = FindBestAttackTarget(myMinionsSimulation.ToList(), enemy, used);
            optimalAttackedByPattern[enemy] = bestPairing;
        }

        return optimalAttackedByPattern;
    }

    private Minion[] FindBestAttackTarget(List<Minion> myMinions, Minion target, bool[] used)
    {
        var amountOfMinions = myMinions.Count;
        var differentials = new int[amountOfMinions + 1, target.CurrentHealth + 1];
        var included = new bool[amountOfMinions + 1, target.CurrentHealth + 1];

        for (var i = 0; i < amountOfMinions; i++)
        {
            var damage = myMinions[i].Damage;
            if (!used[i])
            {
                for (var j = 1; j <= target.CurrentHealth; j++)
                {
                    if (damage <= j && differentials[i, j - damage] + damage >= differentials[i, j])
                    {
                        differentials[i + 1, j] = differentials[i, j - damage] + damage;
                        included[i + 1, j] = true;
                    }
                    else
                    {
                        differentials[i + 1, j] = differentials[i, j];
                    }
                }
            }
            else
            {
                for (var j = 1; j <= target.CurrentHealth; j++)
                {
                    differentials[i + 1, j] = differentials[i, j];
                }
            }
        }

        var pairing = new List<Minion>();
        var sum = differentials[amountOfMinions, target.CurrentHealth];
        for (var i = amountOfMinions; i > 0 && sum > 0; i--)
        {
            if (included[i, target.CurrentHealth])
            {
                var minion = myMinions[i - 1];
                pairing.Add(minion);
                used[i - 1] = true;
                sum -= minion.Damage;
                target.CurrentHealth -= minion.Damage;
            }
        }

        return pairing.ToArray();
    }
}
