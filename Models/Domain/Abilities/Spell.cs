using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain.Abilities
{
    public class Spell
    {
        public BattleClass BattleClass { get; set; }
        public string Name { get; set; }
        public List<Effect> Effects { get; set; } = new List<Effect>();

        public void Cast()
        {
            throw new NotImplementedException();
        }
    }
}
