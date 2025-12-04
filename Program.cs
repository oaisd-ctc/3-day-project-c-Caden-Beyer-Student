using PokemonGame.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==== POKÉMON C# GAME ====");

        List<Pokemon> playerTeam = TeamBuilder.ChooseTeam();

        var enemyTeam = new List<Pokemon>();
        var available = TeamBuilder.AllPokemon.Where(x => !playerTeam.Contains(x)).ToList();
        Random r = new Random();

        for (int i = 0; i < 3; i++)
            enemyTeam.Add(available[r.Next(available.Count)]);

        Console.WriteLine("\nYour battle begins!");

        int playerIndex = 0;
        int enemyIndex = 0;

        while (playerIndex < 3 && enemyIndex < 3)
        {
            Pokemon p = playerTeam[playerIndex];
            Pokemon e = enemyTeam[enemyIndex];

            p.ResetHP();
            e.ResetHP();

            Console.WriteLine($"\nRound: {playerIndex + 1}");
            Console.WriteLine($"{p.Name} VS {e.Name}");

            Battle battle = new Battle(p, e);
            Pokemon winner = battle.RunTurn();

            if (winner == p)
            {
                Console.WriteLine($"{p.Name} wins the round!");
                enemyIndex++;
            }
            else
            {
                Console.WriteLine($"{e.Name} wins the round!");
                playerIndex++;
            }
        }

        Console.WriteLine(playerIndex < enemyIndex
            ? "\nYOU WIN THE BATTLE!"
            : "\nYOU LOST THE BATTLE...");
    }
}