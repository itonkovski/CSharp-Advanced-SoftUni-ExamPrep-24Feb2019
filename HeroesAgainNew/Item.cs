﻿using System;
using System.Text;

namespace HeroesAgainNew
{
    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"  * Strength: {this.Strength}")
                .AppendLine($"  * Ability: {this.Ability}")
                .AppendLine($"  * Intelligence: {this.Intelligence}");

            return sb.ToString().TrimEnd();
        }
    }
}
