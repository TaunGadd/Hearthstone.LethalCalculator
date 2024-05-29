using Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Weapon
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public List<IPassive> Passives { get; set; } = new List<IPassive>();
    }
}
