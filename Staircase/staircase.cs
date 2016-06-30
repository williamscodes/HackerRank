/****************************************************************************
 * THIS APPLICATION DEMONSTRATES THE ANSWER TO HACKER RANK PUZZLE STAIRCASE *
 ***************************************************************************/

/* INCLUDE DIRECTIVES */
using System;
using System.Text;

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
            StringBuilder value = new StringBuilder(num);
            int rowCount = 1;

            // FOR EACH ROW / INDEX IN THE ARRAY COMPOSE THE REQUIRED STRING
            for (int rowNum = 0; rowNum <= (staircase.Length - 1); rowNum++)
            {
                // FOR EACH NUMERICAL VALUE OF COUNTER WHILE LESS THAN THE PRODUCT OF NUM - ROWCOUNT APPEND A SPACE
                for (int counter = 1; counter <= num - rowCount; counter++)
                {
                    value = value.Append(" ");
                }

                // FOR EACH NUMERICAL VALUE OF COUNTER2 WHILE LESS THAN ROWCOUNT APPEND A #
                for (int counter2 = 0; counter2 < rowCount; counter2++)
                {
                    value = value.Append("#");
                }

                // STORE STRINGBUILDER VALUE TO ARRAY INDEX
                staircase[rowNum] = value.ToString();
                // CLEAR THE STRING BUILDER OBJECT OF ALL CHARACTERS
                value.Clear();
                // INCREMENT ROWCOUNT
                rowCount++;
            }
            // RETURN COMPLETED STAIRCASE ARRAY
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
