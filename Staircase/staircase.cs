/****************************************************************************
 * THIS APPLICATION DEMONSTRATES THE ANSWER TO HACKER RANK PUZZLE STAIRCASE *
 ***************************************************************************/

/* INCLUDE DIRECTIVES */
using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLE DECLARATION */
            int num = 6; // THIS IS A INPUT NUMBER FROM THE PUZZLE WHICH SHOULD BE CHANGED FOR TESTING

            // CALL PYRAMID BUILDER
            string[] output = pyramidBuilder(num);

            // CALL OUTPUT PYRAMID TO OUTPUT RESULT ANSWER TO CONSOLE
            outputPyramid(output);
        }

        /* DECLARE AND DEFINE PYRAMIDBUILDER TO BUILD EACH STRING AND STORE IN ARRAY CREATING A RIGHT ADJUSTED PYRAMID */
        static string[] pyramidBuilder(int num)
        {
            // STAIRCASE IS CONTAINER FOR STAIRCASE OUTPUT
            string[] staircase = new string[num];
            
            for (int counter = 1; counter <= num; counter++)
            {
                // CREATE NEW BLANK AND STAIR STRINGS WITH CORRECT REOCCURANCE
                string blank = new string(' ', (num - counter));
                string stair = new string('#', counter);

                // SET VALUE OF STAIRCASE INDEX TO CONCATENATION OF BLANK AND STAIR
                staircase[counter - 1] = blank + stair;
            }

            // RETURN STAIRCASE
            return staircase;
        }

        /* DECLARE AND DEFINE OUTPUTPYRAMID TO OUTPUT THE BUILT SOLUTION TO THE CONSOLE */
        static void outputPyramid (string[] array)
        {
            foreach (string ar in array)
            {
                Console.WriteLine(ar);
            }
        }
    }
}
