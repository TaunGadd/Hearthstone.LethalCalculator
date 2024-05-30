namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public abstract class BattleCry : Effect, ITriggerableEffect
    {
        private readonly Effect _effect;

        protected BattleCry(Effect effect)
        {
            _effect = effect;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
