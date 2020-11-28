using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HeroesNewPractise
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero heroToRemove = this.data
                .FirstOrDefault(x => x.Name == name);

            this.data.Remove(heroToRemove);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero heroWithHighestStrength = this.data
                .OrderByDescending(x => x.Item.Strength)
                .FirstOrDefault();

            return heroWithHighestStrength;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero heroWithHighestAbility = this.data
                .OrderByDescending(x => x.Item.Ability)
                .FirstOrDefault();

            return heroWithHighestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero heroWithTheHighestIntelligence = this.data
                .OrderByDescending(x => x.Item.Intelligence)
                .FirstOrDefault();

            return heroWithTheHighestIntelligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var hero in this.data)
            {
                sb
                    .AppendLine(hero.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
