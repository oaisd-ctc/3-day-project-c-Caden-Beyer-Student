using System;

public class GhostGame
{

    public void Run()
    {
        Console.Clear();

     
        story();
        int room = 1;
        Random rand = new Random();

            
        
        
        while (room <= 14)
        {
            
            Console.WriteLine("Do you wanna go in Room 1, 2, 3, 4, 5, or 6???");
            Console.WriteLine("You're in Room " + room);
            
            int UserRoom = int.Parse(Console.ReadLine());
            
            if (UserRoom <= 6 && UserRoom >= 1)
            {
                
                int GhostDoor = rand.Next(1, 7);

               
                if (UserRoom == GhostDoor)
                {
                    Console.WriteLine("You Died, loser!!!!!!!!!! You lost you bum!!!!!!!!!!!!!");
                    Console.WriteLine("This game was (unfortunately) made by Sage Lucas Little");
                    break;
                }
                else
                {
                    room++;
                }
                  
            }
            else
            {
                Console.WriteLine("Thats not what I asked you son");
            }

        }
        if(room >= 15)
        {
            Console.WriteLine("You Survived, Congratulations"); 
            Console.WriteLine("You re-awake in the spooky ghost house, you realize you're in an infinite loop that is inescapable, forever and ever tormented until you die...");
            Console.WriteLine("This game was (unfortunately) made by Sage Lucas Little");

        }
    
    }
    public static void story()
    {
        Console.WriteLine("There are 6 rooms to choose from son, however, one room does indeed house a ghost, in which case you will die having chosen that room...");

    }


}
