namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class BattleCry : ComboEffect, ITriggerableEffect
    {
        public override string Name => nameof(BattleCry);
        public override Effect ResultantEffect { get; set; }

        public BattleCry(Effect effect)
        {
            ResultantEffect = effect;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
