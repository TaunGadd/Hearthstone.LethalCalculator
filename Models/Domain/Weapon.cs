using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Weapon : Card
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public List<ITriggerableEffect> Effects { get; set; } = new List<ITriggerableEffect>();

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
