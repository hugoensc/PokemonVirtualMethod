using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonVirtualMethod
{
    class Pokemon
    {
        private string name;
        private string type;
        private int lifePoints;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int LifePoints
        {
            get
            {
                return lifePoints;
            }

            set
            {
                lifePoints = value;
            }
        }

        public Pokemon(string name, string type)
        {
            Type = type;
            Name = name;
            LifePoints = 100;

        }

        public virtual void Attack()
        {

        }

        public void CalculateDamage(int damage)
        {

        }
    }
}
