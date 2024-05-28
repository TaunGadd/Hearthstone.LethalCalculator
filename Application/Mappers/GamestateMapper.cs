using Hearthstone.LethalCalculator.Models.domain;
using Hearthstone.LethalCalculator.Models.dtos;

namespace Hearthstone.LethalCalculator.Application.Mappers;

public class GamestateMapper : IMapper<GamestateDto, Gamestate>
{
    public Gamestate Map(GamestateDto dto)
    {
        return new Gamestate
        {
            // TODO
        };
    }

    public GamestateDto Map(Gamestate domain)
    {
        return new GamestateDto
        {
            // TODO
        };
    }
}
