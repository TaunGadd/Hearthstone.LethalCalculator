using Hearthstone.LethalCalculator.Models.dtos;

namespace Hearthstone.LethalCalculator.Application.Interfaces;

public interface IGamestateApplication
{
    bool IsLethal(GamestateDto dto);
}