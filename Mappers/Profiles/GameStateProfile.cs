using AutoMapper;
using Hearthstone.LethalCalculator.Models.Domain;
using Hearthstone.LethalCalculator.Models.Dtos;

namespace Hearthstone.LethalCalculator.Mappers.Profiles
{
    public class GameStateProfile : Profile
    {
        public GameStateProfile()
        {
            CreateMap<GameStateDto, GameState>().ReverseMap();
        }
    }
}
