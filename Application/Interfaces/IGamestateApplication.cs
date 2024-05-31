using Hearthstone.LethalCalculator.Models.Dtos;

namespace Hearthstone.LethalCalculator.Application.Interfaces;

public interface IGamestateApplication
{
    bool IsLethal(GameStateDto dto);
}