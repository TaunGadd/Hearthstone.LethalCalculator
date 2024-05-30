using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Weapon
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public List<ITriggerableEffect> Passives { get; set; } = new List<ITriggerableEffect>();
    }
}
