/**********************************************************************************************************************
 * THIS PROGRAM CREATES A BOT TO SAVE THE PRINCESS AND MEETS THE REQUIREMENTS FOR THE HACKERRANK PUZZLE SAVE PRINCESS *
 *********************************************************************************************************************/

// DIRECTIVES
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SavePrincess
{
    class Program
    {
        static int gridSize;

        static void Main(string[] args)
        {
            /* VARIABLE DECLARATION */
            string map = "";
            char[,] board = new char[gridSize,gridSize];

            // CREATE MAP AND SETUP BOARD
            map = OpenFile();
            board = CreateMap(map);

            // CREATE PLAYERS
            Player princess = new Player('p');
            Player mario = new Player('m');

            // PLACE PLAYERS ON THE BOARD
            mario.findPosition(board, gridSize);
            princess.findPosition(board, gridSize);

            // GAME LOOP WHILE MARIO HAS NOT CAUGHT PRINCESS
            while (princess.x != mario.x && princess.y != mario.y)
            {
                // MOVE MARIO TOWARDS PRINCESS
                mario.playerMove(princess, mario);
            }

        }

        // ATTEMPT TO OPEN THE FILE AND READ THE MAP
        public static string OpenFile()
        {
            try
            {
                // DECLARE PATH TO STORE THE PATH TO THE FILE RESOURCE
                string path = @"c:\Users\tw599\Documents\SavePrincess.txt"; //change this file location to local machine environment

                // READ THE TEXT FILE INTO THE STRING BUILDER
                StringBuilder map = new StringBuilder(File.ReadAllText(path));
                // GET EQUALATERIAL GRIDSIZE VALUE FROM BEGINNING OF FILE
                gridSize = int.Parse(map[0].ToString());
                // REMOVE GRIDSIZE VALUE FROM STRINGBUILDER TO BUILD MAP
                map.Remove(0, 3);

                string map1 = map.ToString();
                //string map2 = Regex.Replace(map1, @"\t|\n|\r", "");
                map1 = Regex.Replace(map1, @"\t|\n|\r", "");
                return map1;
            }
            // CATCH FILE NOT FOUND EXCEPTION
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
                return "0";
            }
            // CATCH ALL OTHER EXCEPTIONS
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "0";
            }
        }

        // CREATE THE GAMEBOARD THAT THE BOT WILL TRAVERSE
        public static char[,] CreateMap(string map)
        {
            // CREATE NEW CHAR ARRAY AND INDEX NAME COORD
            char[,] gridMap = new char[gridSize, gridSize];
            int coord = 0;

            // ITTERATE THROUGH MULTI-DIMENSIONAL ARRAY TO OUTPUT MAP CHARACTERS
            for (int counter = 0; counter < gridSize; counter++)
            {
                for (int iter = 0; iter < gridSize; iter++)
                {
                    gridMap[counter, iter] = map[coord];
                    coord++;
                }
            }

            // RETURN MAP
            return gridMap;
        }
    }

    /* DECLARE AND DEFINE THE PLAYER CLASS */
    class Player
    {
        /* VARIABLE DECLARATION */
        public char name;
        public int x, y;

        /* METHOD DECLARATION */
        public Player(char name)
        {
            this.name = name;
            this.x = 0;
            this.y = 0;
        }

        // DISPLAY POSITION OF THE PLAYER OR TARGET
        public void displayPosition()
        {
            Console.WriteLine("Player " + this.name + " position is " + this.x + ", " + this.y);
        }

        // FIND THE POSITION OF THE PLAYER OR TARGET
        public void findPosition(char[,] array, int bounds)
        {
            for (int counter = 0; counter < bounds; counter++)
            {
                for (int iter = 0; iter < bounds; iter++)
                {
                    if (array[counter, iter] == this.name)
                    {
                        this.y = iter;
                        this.x = counter;
                    }
                }
            }
        }

        // DETERMINE THE MOVE THE PLAYER SHOULD MAKE TO REACH THE TARGET
        public void playerMove(Player target1, Player player1)
        {
            if (target1.x > player1.x)
            {
                Console.WriteLine("DOWN");
                this.x++;
            }
            else if (target1.x < player1.x)
            {
                Console.WriteLine("UP");
                this.x--;
            }

            if (target1.y > player1.y)
            {
                Console.WriteLine("RIGHT");
                this.y++;
            }
            else if (target1.y < player1.y)
            {
                Console.WriteLine("LEFT");
                this.y--;
            }
        }
    }
}
