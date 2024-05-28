using Hearthstone.LethalCalculator.Models.domain;

namespace Hearthstone.LethalCalculator.Service.Interfaces;

public interface ILethalCalculatorService
{
    public bool IsLethal(Gamestate gamestate);
}
