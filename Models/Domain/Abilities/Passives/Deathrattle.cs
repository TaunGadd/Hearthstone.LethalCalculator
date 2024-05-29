using Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives.Effects;

namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives
{
    public class Deathrattle : IPassive
    {
        private readonly IEffect _effect;

        public Deathrattle(IEffect effect)
        {
            _effect = effect;
        }

        public void Trigger()
        {
            _effect.Trigger();
        }
    }
}
