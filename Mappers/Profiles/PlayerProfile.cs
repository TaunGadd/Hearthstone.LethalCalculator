using AutoMapper;
using Hearthstone.LethalCalculator.Models.Domain.Characters;
using Hearthstone.LethalCalculator.Models.Dtos;

namespace Hearthstone.LethalCalculator.Mappers.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<PlayerDto, Player>().ReverseMap();
        }
    }
}
