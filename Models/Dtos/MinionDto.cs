namespace Hearthstone.LethalCalculator.Models.Dtos
{
    public class MinionDto
    {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public List<string> Effects { get; set; } = new List<string>();
    }
}
