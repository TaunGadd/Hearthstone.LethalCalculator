using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Mappers;

public class EffectFactory : IEffectFactory
{
    public Effect CreateEffect(string effect)
    {
        var components = effect.Split(':');

        if (components.Length == 1)
        {
            // Triggerable Effect
            return CreateStandaloneEffect(components[0]);
        }
        else
        {
            // Triggerable effect with resultant effect
            return CreateComboEffect(components);
        }
    }

    private Effect CreateStandaloneEffect(string effect)
    {
        return effect switch
        {
            nameof(Freeze) => new Freeze(),
            _ => throw new NotSupportedException(),
        };
    }

    private ComboEffect CreateComboEffect(string[] effects)
    {
        var resultantEffect = effects[1] switch
        {
            nameof(DoDamage) => new DoDamage(),
            _ => throw new NotSupportedException(),
        };

        return effects[0] switch
        {
            nameof(BattleCry) => new BattleCry(resultantEffect),
            nameof(Deathrattle) => new Deathrattle(resultantEffect),
            _ => throw new NotSupportedException(),
        };
    }
}
