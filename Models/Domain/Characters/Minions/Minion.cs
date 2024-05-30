using Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Interfaces;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters.Minions
{
    public class Minion<T> where T : Class
    {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public List<IPassive> Passives { get; set; } = new List<IPassive>();

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
