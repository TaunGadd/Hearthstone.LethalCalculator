namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public abstract class ComboEffect : Effect
    {
        public abstract Effect ResultantEffect { get; set;  }
    }
}
