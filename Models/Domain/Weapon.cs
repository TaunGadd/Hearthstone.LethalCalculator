using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Weapon
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public List<Affect> Affects { get; set; } = new List<Affect>();
    }
}
