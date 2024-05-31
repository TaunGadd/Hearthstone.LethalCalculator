namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class BattleCry : Effect, ITriggerableEffect
    {
        public override string Name => nameof(BattleCry);
        private readonly Effect _effect;

        public BattleCry(Effect effect)
        {
            _effect = effect;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
