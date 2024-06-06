using Hearthstone.LethalCalculator.Models.Domain;
using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
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

        var opponentTauntHealth = gamestate.OpponentMinions
            .Where(x => x.Passives.Select(y => y.Name).Contains(nameof(Taunt)))
            .Select(x => x.CurrentHealth)
            .Sum();

        // Temporary - this does not work if there are a one or two minions with really high damage
        if (totalDamage >= opponentTauntHealth + gamestate.Opponent.CurrentHealth)
        {
            return true;
        }
        return false;
    }
}
