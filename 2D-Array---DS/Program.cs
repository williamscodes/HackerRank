/**************************************************************************
 * THIS APPLICATION IS THE SOLUTION TO THE 2DARRAY - DS HACKERRANK PUZZLE *
 *************************************************************************/

/* DIRECTIVES */ 
using System;
using System.Linq;

namespace _2DArrayDS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLE DECLARATIONS */
            // DECLARE THE SIZE OF THE ARRAY BOUNDS AND NUMBER OF FIGURES
            int size = 6;
            int numOfGlasses = 16;

            // DECLARE THE SUM ARRAY AND THE INDEX COUNTERS
            int[] sum = new int[numOfGlasses];
            int index = 0;
            int rowNum = 0;
            int rowIndex = 0;
            int colIndex = 0;

            // CREATE AN INPUT ARRAY
            int[][] arr = new int[size][];

            // PARSE USER INPUT INTO ARRAY
            for (int arr_i = 0; arr_i < size; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            // WHILE ROWNUM ALLOWS FOR HOURGLASSES IN THE ARRAY
            while (rowNum < size - 2)
            {
                

                // MOVE THE HOURGLASS ALONG THE ARRAY
                for (int i = 0; i <= 3; i++)
                {
                    sum[index] = returnHourGlassValue(arr, rowIndex, colIndex + i);
                    index++;
                }

                // INCREMENT VARIABLES
                rowIndex++;
                rowNum++;
            }

            // OUTPUT MAX VALUE OF ARRAY
            Console.WriteLine(sum.Max());
        }

        /* DECLARE THE RETURNHOURGLASSVALUE METHOD TO CALCULATE THE FIGURES VALUE */
        static int returnHourGlassValue(int[][] input, int topRow, int left)
        {
            // VARIABLE DECLARATION
            int middleRow = topRow + 1;
            int bottomRow = topRow + 2;

            // DECLARE AND INITIALIZE SUM TO GET HOURGLASS SUM
            int sum = (input[topRow][left] + input[topRow][left + 1] + input[topRow][left + 2]);
            sum += (input[middleRow][left + 1]);
            sum += (input[bottomRow][left] + input[bottomRow][left + 1] + input[bottomRow][left + 2]);

            // RETURN SUM
            return sum;
        }
    }
}
