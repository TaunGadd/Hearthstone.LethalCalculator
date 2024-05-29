namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives.Effects
{
    public class DoDamage : IEffect
    {
        private readonly int _damage;
        private readonly int _targetId;

        public DoDamage(int target, int damage)
        {
            _damage = damage;
            _targetId = target;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
