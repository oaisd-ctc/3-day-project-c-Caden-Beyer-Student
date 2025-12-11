using System;
using System.Threading;
enum JumpState { Grounded, Ascending, Hanging, Descending }
class DinoGame
{
    public void Run()
    {
        Console.CursorVisible = false;
        string level = "                           AAA                AAA                       AAA                      AAA            AAA                                 A             A                   AAA                       AA";
        int consoleWidth = Console.WindowWidth;
        int messageLength = level.Length;
        bool keepRunning = true;

        int dinoYPosition = 8;


        JumpState jumpState = JumpState.Grounded;

        int topY = 4;
        int groundY = 8;
        int hangFrames = 0;
        int hangDuration = 4;
        int ascentSpeed = 1;
        int descentSpeed = 1;

        int score = 0;

        Console.Clear();

        while (keepRunning)
        {
            for (int i = 0; keepRunning; i++)
            {
                if (Console.WindowWidth < 20)
                {
                    continue;
                }

                int scrollOffset = i % messageLength;

                for (int y = 0; y < 10; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write(new string(' ', consoleWidth));

                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Q)
                    {
                        keepRunning = false;
                        break;

                    }
                    else if (key.Key == ConsoleKey.Spacebar && dinoYPosition == 8)
                    {
                        jumpState = JumpState.Ascending;

                    }

                }

                if (!keepRunning) break;

                switch (jumpState)
                {
                    case JumpState.Grounded:
                        break;

                    case JumpState.Ascending:
                        dinoYPosition -= ascentSpeed;
                        if (dinoYPosition < +topY)
                        {
                            dinoYPosition = topY;
                            hangFrames = hangDuration;
                            jumpState = JumpState.Hanging;

                        }
                        break;

                    case JumpState.Hanging:
                        if (hangFrames > 0) hangFrames--;
                        else jumpState = JumpState.Descending;
                        break;

                    case JumpState.Descending:
                        dinoYPosition += descentSpeed;
                        if (dinoYPosition >= groundY)
                        {
                            dinoYPosition = groundY;
                            jumpState = JumpState.Grounded;

                        }
                        break;

                }

                Console.SetCursorPosition(0, 9);
                Console.Write("‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾");

                consoleWidth = Console.WindowWidth;
                if (consoleWidth > messageLength) consoleWidth = messageLength;

                string currentDisplay;

                if (scrollOffset + consoleWidth <= messageLength)
                {
                    currentDisplay = level.Substring(scrollOffset, consoleWidth);

                }
                else
                {
                    int lengthOfEndPart = messageLength - scrollOffset;
                    int lengthOfStartPart = consoleWidth - lengthOfEndPart;

                    if (lengthOfStartPart < 0) lengthOfStartPart = 0;

                    currentDisplay = level.Substring(scrollOffset, lengthOfEndPart) + level.Substring(0, lengthOfStartPart);

                }

                Console.SetCursorPosition(0, 8);
                Console.Write(currentDisplay);

                int dinoXposition = 5;
                Console.SetCursorPosition(dinoXposition, dinoYPosition);
                Console.Write("I");

                char obstacle = currentDisplay[dinoXposition];
                if (obstacle == 'A' && dinoYPosition == 8)
                {
                    keepRunning = false;
                    break;

                }

                score++;

                int levelNum = 1;

                if (score < 500)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.Write($"Score : {score:D6} Level: {levelNum} (Q/Esc to Exit)");

                    Thread.Sleep(40);

                }
                else if (score < 1000)
                {
                    levelNum++;
                    Console.SetCursorPosition(0, 1);
                    Console.Write($"Score : {score:D6} Level: {levelNum} (Q/Esc to Exit)");

                    Thread.Sleep(35);

                }
                else if (score < 2000)
                {
                    levelNum++;
                    Console.SetCursorPosition(0, 1);
                    Console.Write($"Score : {score:D6} Level: {levelNum} (Q/Esc to Exit)");

                    Thread.Sleep(30);
                }
                else
                {
                    levelNum++;
                    Console.SetCursorPosition(0, 1);
                    Console.Write($"Score : {score:D6} Level: {levelNum} (Q/Esc to Exit)");

                    Thread.Sleep(20);

                }

            }
        }
        Console.Clear();
        Console.WriteLine("Game over or quit pressed.");
        Console.WriteLine($"Final Score: {score}");
        Console.WriteLine("This game was made by Caden Beyer");
        Console.ReadKey();

    }

}