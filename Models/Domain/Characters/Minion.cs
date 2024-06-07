using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Enums;
using Newtonsoft.Json;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters
{
    public class Minion : Card
    {
        public BattleClass BattleClass { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public List<Effect> Passives { get; set; } = new List<Effect>();

        public bool IsDead => CurrentHealth <= 0;

        public override void PlayCard()
        {
            throw new NotImplementedException();
        }

        public void Attack(Minion target)
        {
            // TODO: Effects not yet taken into account
            target.CurrentHealth -= Damage;
            CurrentHealth -= target.Damage;
        }

        public void Attack(Player target)
        {
            target.CurrentHealth -= Damage;
        }

        public Minion DeepCopy()
        {
            string serializedObject = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Minion>(serializedObject);
        }
    }
}
