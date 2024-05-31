using Hearthstone.LethalCalculator.Models.Domain.Characters;

namespace Hearthstone.LethalCalculator.Models.Domain;

public class GameState
{
    public Player Self { get; set; }
    public Player Opponent { get; set; }

    public List<Minion> MyMinions { get; set; }
    public List<Minion> OpponentMinions { get; set; }
}
