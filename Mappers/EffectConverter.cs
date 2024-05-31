using AutoMapper;
using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Mappers;

public class EffectConverter : ITypeConverter<string, Effect>
{
    private readonly EffectFactory _effectFactory;

    public EffectConverter(EffectFactory effectFactory)
    {
        _effectFactory = effectFactory;
    }

    public Effect Convert(string source, Effect destination, ResolutionContext context)
    {
        return _effectFactory.CreateEffect(source);
    }
}

public class EffectListConverter : ITypeConverter<List<string>, List<Effect>>
{
    private readonly EffectFactory _effectFactory;

    public EffectListConverter(EffectFactory effectFactory)
    {
        _effectFactory = effectFactory;
    }

    public List<Effect> Convert(List<string> source, List<Effect> destination, ResolutionContext context)
    {
        return source.Select(_effectFactory.CreateEffect).ToList();
    }
}
