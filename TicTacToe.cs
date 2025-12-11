using System;

public class TicTacToe
{
    public void Run()
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char CurrentPlayer = 'X';
        bool gamerunning = true;

        while (gamerunning)
        {
            Console.Clear();
            PrintBoard(board);

            Console.WriteLine($"Player {CurrentPlayer}, enter your move (1-9): ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O')
            {
                board[move - 1] = CurrentPlayer;

                if (CheckWin(board, CurrentPlayer))
                {
                    Console.Clear();
                    PrintBoard(board);
                    Console.WriteLine($"Player {CurrentPlayer} wins!");
                    Console.WriteLine("This game was made by OwenTheWalsh");
                    gamerunning = false;
                }
                else if (CheckDraw(board))
                {
                    Console.Clear();
                    PrintBoard(board);
                    Console.WriteLine("It's a draw!");
                    Console.WriteLine("This game was made by OwenTheWalsh");
                    gamerunning = false;
                }
                else
                {
                    CurrentPlayer = (CurrentPlayer == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Invalid move. Try again.");
                Console.ReadKey();
            }

        }
    }
    public static void PrintBoard(char[] board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }
    public static bool CheckWin(char[] b, char player)
    {
        int[,] wins = new int[,]
        {
            {0,1,2}, {3,4,5}, {6,7,8},
            {0,3,6}, {1,4,7}, {2,5,8},
            {0,4,8}, {2,4,6}
        };

        for (int i = 0; i < wins.GetLength(0); i++)
        {
            int a = wins[i, 0];
            int c = wins[i, 1];
            int d = wins[i, 2];
            if (b[a] == player && b[c] == player && b[d] == player)
            {
                return true;
            }
        }
        return false;
    }
    public static bool CheckDraw(char[] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                return false;
            }
        }
        return true;
    }
}