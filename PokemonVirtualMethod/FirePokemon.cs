using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonVirtualMethod
{
    class FirePokemon : Pokemon 
    {
        public FirePokemon(string name, string type) : base(name, type)
        {

        }

        public override void Attack(Pokemon attackedPokemon)
        {
            if (LifePoints > 0)
            {
                int damage = 11;
                Console.WriteLine($"{Name} ha usado Bola de Fuego");
                attackedPokemon.CalculateDamage(damage);
            }
        }
    }
}
