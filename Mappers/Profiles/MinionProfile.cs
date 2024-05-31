using AutoMapper;
using Hearthstone.LethalCalculator.Models.Domain.Characters;
using Hearthstone.LethalCalculator.Models.Dtos;

namespace Hearthstone.LethalCalculator.Mappers.Profiles
{
    public class MinionProfile : Profile
    {
        public MinionProfile()
        {
            CreateMap<MinionDto, Minion>().ReverseMap();
        }
    }
}
