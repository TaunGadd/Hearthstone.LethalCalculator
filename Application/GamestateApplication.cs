using Hearthstone.LethalCalculator.Application.Interfaces;
using Hearthstone.LethalCalculator.Application.Mappers;
using Hearthstone.LethalCalculator.Models.Dtos;
using Hearthstone.LethalCalculator.Service.Interfaces;

namespace Hearthstone.LethalCalculator.Application;

public class GamestateApplication : IGamestateApplication
{
    readonly ILethalCalculatorService _lethalCalculatorService;
    readonly GamestateMapper _mapper;

    public GamestateApplication(
        ILethalCalculatorService lethalCalculatorService,
        GamestateMapper mapper
        )
    {
        _lethalCalculatorService = lethalCalculatorService;
        _mapper = mapper;
    }

    public bool IsLethal(GamestateDto dto)
    {
        var domain = _mapper.Map(dto);
        var result = _lethalCalculatorService.IsLethal(domain);
        return result;
    }
}
