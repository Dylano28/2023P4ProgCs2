using System.Linq.Expressions;

namespace ConsoleApp3
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name { get; set; }
        internal Element element;
        internal Element weakness;


        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
            if (weakness == element)
            {
                int critdamage = damage / 2;
                target.TakeDamage(critdamage);
            }
        }
        internal Skill(int damage, int energyCost, string name, Element element)
        {
            this.name = name;
            this.damage = damage;
            this.energyCost = energyCost;
            this.element = element;
        }

    }


}