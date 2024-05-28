namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.HeroPower;

public abstract class HeroPower
{
    public int Cost { get; set; } = 2;
    public abstract void Perform();
}
