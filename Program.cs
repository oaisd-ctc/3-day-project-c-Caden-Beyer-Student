using System;
using System.Threading;

class HorizontalScroller
{
    static void Main()
    {
        
        string message = "___________________________________________________________________AAA__________________________________________________________________AAAA______________________________________________________AAA____________________________________________________"; 
        int consoleWidth = Console.WindowWidth;
        int messageLength = message.Length;
        bool keepRunning = true;

        Console.Clear();

        while (keepRunning)
        {
            for (int i = 0; i <= messageLength; i++)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Q)
                    {
                        keepRunning = false;
                        break;
                    }
                }

                if (!keepRunning) break;
                Console.SetCursorPosition(0, 0); 
                Console.Write(new string(' ', consoleWidth));
                string currentDisplay;

                if (i + consoleWidth <= messageLength)
                {
                    currentDisplay = message.Substring(i, consoleWidth);
                }
                else
                {
                    int lengthOfEndPart = messageLength - i;
                    int lengthOfStartPart = consoleWidth - lengthOfEndPart;
                    
                    lengthOfStartPart = Math.Max(0, lengthOfStartPart);

                    if (lengthOfStartPart <= messageLength)
                    {
                        currentDisplay = message.Substring(i, lengthOfEndPart) + message.Substring(0, lengthOfStartPart);
                    }
                    else
                    {
                        currentDisplay = message.Substring(i);
                    }
                }

                Console.SetCursorPosition(0, 0);
                Console.Write(currentDisplay.Substring(0, Math.Min(currentDisplay.Length, consoleWidth)));

                Thread.Sleep(50); 
            }
        }

        Console.SetCursorPosition(0, 1);
        Console.WriteLine("Program stopped by user action. Press any key to close the window.");
        Console.ReadKey();
    }
}