/***********************************************************************************************
 * THIS APPLICATION CREATES A BOT THAT WILL SAVE THE PRINCESS IN THE SHORTEST AMOUNT OF MOVES. *
 * THE APPLICAITON IS A SOLUTION TO BOT SAVES PRINCESS PUZZLE ON HACKERRANK.                   *
 **********************************************************************************************/
using System;

namespace BotSavesPrincess
{
    class Program
    {
        // FORWARD DECLARATION OF METHOD
        static void displayPathtoPrincess(int n, String[] grid)
        {
        }

        static void Main(String[] args)
        {
            /* VARIABLE DECLARATION */
            int m = 0;
            String[] grid = new String[m];

            // SET M EQUAL TO GRID SIZE OF MAP
            m = int.Parse(Console.ReadLine());

            // ITERATE THROUGH THE INDEXES OF GRID AND STORE THE MAP STRINGS FOR THE GRID
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine();
            }

            /* DETERMINE PATH TO THE PRINCESS */
            displayPathtoPrincess(m, grid);
            {
                /* VARIABLE DECLARATION */
                int princessX = -1;
                int princessY = -1;
                int marioX = -1;
                int marioY = -1;

                // LOCATE PRINCESS
                for (int counter = 0; counter < m; counter++)
                {
                    princessY = grid[counter].IndexOf('p');

                    if (princessY > -1)
                    {
                        princessX = counter;
                        break;
                    }
                }

                // LOCATE PLAYER
                for (int counter = 0; counter < m; counter++)
                {
                    marioY = grid[counter].IndexOf('m');

                    if (marioY > -1)
                    {
                        marioX = counter;
                        break;
                    }
                }

                // GAME LOOP
                while (marioX != princessX && marioY != princessY)
                {
                    // TESTING
                    /*
                    Console.Error.WriteLine("Mario: " + marioX + ", " + marioY);
                    Console.Error.WriteLine("Princess: " + princessX + ", " + princessY);
                    */

                    // MOVE MARIO X POSITION
                    if (marioX > princessX)
                    {
                        Console.WriteLine("UP");
                        marioX--;
                    }
                    else if (marioX < princessX)
                    {
                        Console.WriteLine("DOWN");
                        marioX++;
                    }

                    // MOVE MARIO Y POSITION
                    if (marioY > princessY)
                    {
                        Console.WriteLine("LEFT");
                        marioY--;
                    }
                    else if (marioY < princessY)
                    {
                        Console.WriteLine("RIGHT");
                        marioY++;
                    }
                }
            }
        }
    }
}
