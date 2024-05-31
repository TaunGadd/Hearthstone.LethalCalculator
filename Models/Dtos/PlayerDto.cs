using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Dtos
{
    public class PlayerDto
    {
        public BattleClass BattleClass { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Armour { get; set; }
        public WeaponDto Weapon { get; set; }
        public HeroPowerDto HeroPower { get; set; }
        public List<string> Effects { get; set; } = [];


        public List<string> Hand { get; set; }
        public List<string> Deck { get; set; }
    }
}
