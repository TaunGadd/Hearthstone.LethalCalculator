using Hearthstone.LethalCalculator.Models.Domain.Abilities.Passives.Effects;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Interfaces;

namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.HeroPowers;

public class HeroPower<T> where T : Class
{
    public string Name { get; init; }
    public int Cost { get; set; }
    public List<IEffect> Effects { get; set; } = new List<IEffect>();

    public void Perform(Class thing)
    {
        throw new NotImplementedException();
    }
}
