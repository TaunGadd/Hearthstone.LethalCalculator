using Hearthstone.LethalCalculator.Models.Domain.Abilities.HeroPower;
using Hearthstone.LethalCalculator.Models.Domain.Characters.Interfaces;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters.Classes
{
    public class DeathKnight : IClass
    {
        public DeathKnight()
        {
            HeroPower = new RaiseDead();
        }

        public HeroPower HeroPower { get; set; }
    }
}
