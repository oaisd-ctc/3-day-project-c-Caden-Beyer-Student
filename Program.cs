using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("Choose your game:");
        Console.WriteLine("1: Dino Game");
        Console.WriteLine("2: Ghost Game");
        Console.WriteLine("3: Tic Tac Toe");
        Console.WriteLine("4: Pokemon Battle");
        Console.Write("Enter the game you want to play (1-4): ");

        while (true)
        {
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                DinoGame dino = new DinoGame();
                dino.Run();
                break;
            }
            else if (choice == "2")
            {
                GhostGame ghost = new GhostGame();
                ghost.Run();
                break;
            }
            else if (choice == "3")
            {
                TicTacToe game = new TicTacToe();
                game.Run();
                break;
            }
            else if (choice == "4")
            {
                PokemonBattle newBattle = new PokemonBattle();
                newBattle.Run();
                break;

            }
            else
            {
                Console.Write("Invalid choice. Please enter a number between 1 and 4: ");

            }

        }

    }
}
