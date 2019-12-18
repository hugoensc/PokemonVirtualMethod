using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonVirtualMethod
{
    class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, string type) : base(name, type)
        {

        }

        public override void Attack(Pokemon attackedPokemon)
        {
            if (LifePoints > 0)
            {
                int damage = 23;
                Console.WriteLine($"{Name} ha usado Chorro de agua");
                attackedPokemon.CalculateDamage(damage);
            }
        }
    }
}
