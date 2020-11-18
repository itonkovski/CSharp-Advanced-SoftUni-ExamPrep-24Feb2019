using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heroesAgain
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        public int Count
        {
            get
            {
                return this.heroes.Count;
            }
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public void Remove(string name)
        {
            Hero targetHero = this.heroes
                .FirstOrDefault(h => h.Name == name);
            this.heroes.Remove(targetHero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.heroes
                .OrderByDescending(x => x.Item.Strength)
                .FirstOrDefault();

            return hero;

        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.heroes
                .OrderByDescending(x => x.Item.Ability)
                .FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.heroes
                .OrderByDescending(x => x.Item.Intelligence)
                .FirstOrDefault();

            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in heroes)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
