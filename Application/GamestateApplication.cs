using AutoMapper;
using Hearthstone.LethalCalculator.Application.Interfaces;
using Hearthstone.LethalCalculator.Models.Domain;
using Hearthstone.LethalCalculator.Models.Dtos;
using Hearthstone.LethalCalculator.Service.Interfaces;

namespace Hearthstone.LethalCalculator.Application;

public class GamestateApplication : IGamestateApplication
{
    readonly ILethalCalculatorService _lethalCalculatorService;
    readonly IMapper _mapper;

    public GamestateApplication(
        ILethalCalculatorService lethalCalculatorService,
        IMapper mapper
        )
    {
        _lethalCalculatorService = lethalCalculatorService;
        _mapper = mapper;
    }

    public bool IsLethal(GameStateDto dto)
    {
        var domain = _mapper.Map<GameState>(dto);
        var result = _lethalCalculatorService.IsLethal(domain);
        return result;
    }
}
