using Hearthstone.LethalCalculator.Models.Domain;

namespace Hearthstone.LethalCalculator.Service.Interfaces;

public interface ILethalCalculatorService
{
    public bool IsLethal(Gamestate gamestate);
}
