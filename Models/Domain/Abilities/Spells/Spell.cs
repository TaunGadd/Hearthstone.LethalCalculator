using Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives.Effects;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Interfaces;

namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Spells
{
    public class Spell<T> where T : Class
    {
        public string Name { get; set; }
        public List<IEffect> Effects { get; set; } = new List<IEffect>();

        public void Cast()
        {
            throw new NotImplementedException();
        }
    }
}
