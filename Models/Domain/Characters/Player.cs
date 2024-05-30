using Hearthstone.LethalCalculator.Models.Domain.Abilities.HeroPowers;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Interfaces;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters
{
    public class Player<T> where T : Class
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Armour { get; set; }
        public Weapon Weapon { get; set; }
        public HeroPower<T> HeroPower { get; set; }
    }
}
