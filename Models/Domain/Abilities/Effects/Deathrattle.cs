namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class Deathrattle : Effect, ITriggerableEffect
    {
        public override string Name => nameof(Deathrattle);
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
