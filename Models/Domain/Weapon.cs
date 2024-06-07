using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Models.Domain
{
    public class Weapon : Card
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public List<Effect> Effects { get; set; } = new List<Effect>();

        public override void PlayCard()
        {
            throw new NotImplementedException();
        }
    }
}
