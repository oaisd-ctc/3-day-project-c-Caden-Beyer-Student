using system;

public class program 
{
    public static void main(string[] args)
    {
     char[] board = {'1','2','3','4','5','6','7','8','9'};
     char CurrentPlayer = 'X';
     bool gamerunning = true;

     while(gamerunning)
     {
        Console.Clear();
        PrintBoard(board);
        
        Console.WriteLine($"Player {CurrentPlayer}, enter your move (1-9): ");
        string input = Console.ReadLine();

        if(int.TryParse(input, out int move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O')
        {
            board[move - 1] = CurrentPlayer;

            if(CheckWin(board, CurrentPlayer))
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine($"Player {CurrentPlayer} wins!");
                gamerunning = false;
            }
            else if(CheckDraw(board))
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine("It's a draw!");
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