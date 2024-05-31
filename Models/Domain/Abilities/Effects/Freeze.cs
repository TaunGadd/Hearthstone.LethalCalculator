namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class Freeze : Effect, ITriggerableEffect
    {
        public override string Name => nameof(Freeze);

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
