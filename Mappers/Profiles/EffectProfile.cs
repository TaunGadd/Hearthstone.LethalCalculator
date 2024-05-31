using AutoMapper;
using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;

namespace Hearthstone.LethalCalculator.Mappers.Profiles
{
    public class EffectProfile : Profile
    {
        public EffectProfile()
        {
            CreateMap<string, Effect>().ConvertUsing<EffectConverter>();
            CreateMap<List<string>, List<Effect>>().ConvertUsing<EffectListConverter>();
        }
    }
}
