namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class Deathrattle : Effect, ITriggerableEffect
    {
        private readonly Effect _effect;

        public Deathrattle(Effect effect)
        {
            _effect = effect;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
