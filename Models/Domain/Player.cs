using Hearthstone.LethalCalculator.Models.Domain.Abilities.HeroPowers;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Interfaces;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Player<T> where T : IClass
    {
        public T Class { get; }

        public int Health { get; set; }
        public int Armour { get; set; }
        public Weapon Weapon { get; set; }
        public HeroPower HeroPower { get; set; }
    }
}
