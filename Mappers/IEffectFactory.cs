using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Mappers
{
    public interface IEffectFactory
    {
        Effect CreateEffect(string effect);
    }
}