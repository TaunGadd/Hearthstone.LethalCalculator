﻿namespace Hearthstone.LethalCalculator.Models.Dtos
{
    public class WeaponDto
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public List<string> Effects { get; set; } = new List<string>();
    }
}