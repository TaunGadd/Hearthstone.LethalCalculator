﻿namespace Hearthstone.LethalCalculator.Models.Domain.Abilities.Effects
{
    public abstract class Effect
    {
        public abstract string Name { get; }
        public string Description { get; set; }
    }
}
