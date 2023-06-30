namespace ConsoleApp3
{
    internal partial class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        internal Element weakness;

       private List<Skill> skills = new List<Skill>();
        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
        internal ConsoleMon(int health, int energy, string name, Element weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.weakness = weakness;
        }


    }
}