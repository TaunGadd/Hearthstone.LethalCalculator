using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain.Abilities;

public class HeroPower
{
    public HeroPower(BattleClass battleClass)
    {
        BattleClass = battleClass;
    }

    public BattleClass BattleClass { get; init; }
    public string Name { get; init; }
    public int Cost { get; set; }
    public List<Effect> Effects { get; set; } = new List<Effect>();

    public void Perform()
    {
        throw new NotImplementedException();
    }
}
