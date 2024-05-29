using Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives.Effects;

namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives
{
    public abstract class BattleCry : IPassive
    {
        private readonly IEffect _effect;

        public BattleCry(IEffect effect)
        {
            _effect = effect;
        }

        public void Trigger()
        {
            _effect.Trigger();
        }
    }
}
