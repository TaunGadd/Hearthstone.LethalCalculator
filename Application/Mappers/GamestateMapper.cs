using Hearthstone.LethalCalculator.Models.Domain;
using Hearthstone.LethalCalculator.Models.Dtos;

namespace Hearthstone.LethalCalculator.Application.Mappers;

public class GamestateMapper : IMapper<GamestateDto, GameState>
{
    public GameState Map(GamestateDto dto)
    {
        return new GameState
        {
            // TODO
        };
    }

    public GamestateDto Map(GameState domain)
    {
        return new GamestateDto
        {
            // TODO
        };
    }
}
