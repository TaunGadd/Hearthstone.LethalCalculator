using Hearthstone.LethalCalculator.Models.Domain.Characters;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Minions;

namespace Hearthstone.LethalCalculator.Models.Domain;

public class GameState
{
    public Player Self { get; set; }
    public Player Opponent { get; set; }

    public List<Minion> MyMinions { get; set; }
    public List<Minion> OpponentMinions { get; set; }
}
