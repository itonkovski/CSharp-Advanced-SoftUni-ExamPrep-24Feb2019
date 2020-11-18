using System;
using System.Text;

namespace heroesAgain
{
    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Hero: {this.Name} - {this.Level}lvl")
                .AppendLine($"Item:")
                .AppendLine($"  * Strength: {Item.Strength}")
                .AppendLine($"  * Ability: {Item.Ability}")
                .AppendLine($"  * Intelligence: {Item.Intelligence}");

            return sb.ToString().TrimEnd();

        }
    }
}
