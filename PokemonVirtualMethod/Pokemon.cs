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

        public virtual void Attack(Pokemon attackedPokemon)
        {
            Console.WriteLine("Estas dentro del método virtual");
        }

        public void CalculateDamage(int damage)
        {
            if (lifePoints == 0)
            {
                Console.WriteLine($"Es imposible el pokemon ya esta noqueado");
            }
            else
            {
                lifePoints -= damage;
                if (lifePoints < 0)
                {
                    lifePoints = 0;
                    Console.WriteLine($"El pokemon {name} ha sido noqueado. Puntos de vida = {lifePoints}");
                }

                Console.WriteLine($"El pokemon recibio {damage} puntos de daño. Sus Puntos de Vida quedan en --> {lifePoints}");
            }
        }
    }
}
