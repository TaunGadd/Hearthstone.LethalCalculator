namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class Deathrattle : ComboEffect
    {
        public override string Name => nameof(Deathrattle);
        public override Effect ResultantEffect { get; set; }

        public Deathrattle(Effect effect)
        {
            ResultantEffect = effect;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
