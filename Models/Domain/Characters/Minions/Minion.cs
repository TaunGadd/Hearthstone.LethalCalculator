using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters.Minions
{
    public class Minion
    {
        public BattleClass BattleClass { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public List<ITriggerableEffect> Passives { get; set; } = new List<ITriggerableEffect>();

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
