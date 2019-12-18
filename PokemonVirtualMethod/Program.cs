using System;

namespace PokemonVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string pokemonName = "";

            Console.WriteLine("Bienvenido presiona STARP para continuar ...");
            Console.ReadLine();

            Console.WriteLine("Escribe un nombre para tu pokemon tipo Agua");
            pokemonName = Convert.ToString(Console.ReadLine());

            Pokemon player = new WaterPokemon(pokemonName, "Agua");
            Pokemon machine = new FirePokemon("Charmander", "Fuego");

            while (player.LifePoints > 0 && machine.LifePoints > 0)
            {
                Console.WriteLine("Presiona una tecla para atacar...");
                player.Attack(machine);
                machine.Attack(player);
            }

            if (machine.LifePoints == 0)
                Console.WriteLine("Felicidades ya eres un maestro pokemon...");
        }
    }
}
