namespace Hearthstone.LethalCalculator.Models.Dtos;

public class GameStateDto
{
    public PlayerDto Self { get; set; }
    public PlayerDto Opponent { get; set; }

    public List<MinionDto> MyMinions { get; set; }
    public List<MinionDto> OpponentMinions { get; set; }
}
