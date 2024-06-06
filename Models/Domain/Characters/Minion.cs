using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters
{
    public class Minion : Card
    {
        public BattleClass BattleClass { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public List<Effect> Passives { get; set; } = new List<Effect>();

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
