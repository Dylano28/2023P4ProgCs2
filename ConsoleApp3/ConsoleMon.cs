﻿namespace ConsoleApp3
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}