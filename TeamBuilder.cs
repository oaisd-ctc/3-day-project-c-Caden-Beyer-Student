using System.Collections.Generic;

namespace PokemonGame.Models
{
    public static class TeamBuilder
    {
        public static List<Pokemon> AllPokemon = new List<Pokemon>
        {
            new Pokemon("Charmander", "fire", 39, 52, 43, 65,
                new List<Move> {
                    new Move("Scratch", "normal", 40, 100),
                    new Move("Flamethrower", "fire", 90, 100),
                    new Move("Dragon Rage", "dragon", 60, 100)
                }),
            
            new Pokemon("Squirtle", "water", 44, 48, 65, 43,
                new List<Move> {
                    new Move("Tackle", "normal", 40, 100),
                    new Move("Hydro Pump", "water", 110, 80),
                    new Move("Bite", "dark", 60, 100)
                }),

            new Pokemon("Bulbasaur", "grass", 45, 49, 49, 45,
                new List<Move> {
                    new Move("Tackle", "normal", 40, 100),
                    new Move("Razor Leaf", "grass", 55, 95),
                    new Move("Leech Seed", "grass", 0, 90)
                }),

            // Add the rest of the pokemon
        };

        public static List<Pokemon> ChooseTeam()
        {
            List<Pokemon> team = new List<Pokemon>();

            Console.WriteLine("Choose your 3 Pokémon:");

            for (int i = 0; i < AllPokemon.Count; i++)
                Console.WriteLine($"{i + 1}. {AllPokemon[i].Name}");

            while (team.Count < 3)
            {
                Console.Write("Pick a Pokémon #: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                team.Add(AllPokemon[index]);
            }

            return team;
        }
    }
}
