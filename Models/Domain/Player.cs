using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Player
    {
        public int Health { get; set; }
        public int Armour { get; set; }
        public Weapon Weapon { get; set; }
        public Class Class { get; set; }
    }
}
