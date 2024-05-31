namespace Hearthstone.LethalCalculator.Models.Dtos
{
    public class HeroPowerDto
    {
        public string Name { get; init; }
        public int Cost { get; set; }
        public List<string> Effects { get; set; } = new List<string>();
    }
}