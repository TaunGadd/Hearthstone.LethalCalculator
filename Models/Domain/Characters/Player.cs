﻿using Hearthstone.LethalCalculator.Models.Domain.Abilities;
using Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects;
using Hearthstone.LethalCalculator.Models.Enums;

namespace Hearthstone.LethalCalculator.Models.Domain.Characters
{
    public class Player : Card
    {
        public BattleClass BattleClass { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Armour { get; set; }
        public Weapon Weapon { get; set; }
        public HeroPower HeroPower { get; set; }
        public List<Effect> Effects { get; set; } = new List<Effect>();


        public List<Card> Hand { get; set; }
        public List<Card> Deck { get; set; }

        public override void PlayCard()
        {
            throw new NotImplementedException();
        }
    }
}
