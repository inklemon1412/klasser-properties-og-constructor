using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser__properties_og_constructor
{
    internal class Pokemon
    {
        public string Name;
        public int Level;
        public int Health;

        public Pokemon(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
    }
}
