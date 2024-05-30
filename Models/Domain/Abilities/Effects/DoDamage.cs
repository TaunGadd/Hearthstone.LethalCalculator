namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public class DoDamage : Effect
    {
        private readonly int _damage;
        private readonly int[] _targetIds;

        public DoDamage(int[] target, int damage)
        {
            _damage = damage;
            _targetIds = target;
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
