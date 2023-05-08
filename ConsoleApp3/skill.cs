namespace ConsoleApp3
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name;

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
}