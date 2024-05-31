namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class DoDamage : Effect
    {
        public override string Name => nameof(DoDamage);

        public void Trigger(int[] target, int damage)
        {
            throw new NotImplementedException();
        }
    }
}
