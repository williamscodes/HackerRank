/********************************************************************************
 * THIS PROGRAM IS THE SOLUTION TO THE DIAGONAL DIFFERENCE PUZZLE ON HACKERRANK *
 *******************************************************************************/

/* DIRECTIVES */
using System;

namespace DiagonalDifference
{
    class Program
    {

        static void Main(String[] args)
        {
            // DECLARE AND INITIALIZE VARIABLES TO INPUT STREAM
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            // BUILD THE JAGGED ARRAY AND CONVERT TO TYPE INT
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            // DECLARE AND INITIALIZE SUM1 AND SUM2 TO RETURN THE DIAGONAL PRODUCTS
            int sum1 = getPrimaryDiagonal(a, n);
            int sum2 = getSecondaryDiagonal(a, n);

            // OUTPUT THE ABSOLUTE DIFFERENCE BETWEEN THE DIAGONAL PRODUCTS
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }

        // GET THE PRIMARY DIAGONAL PRODUCT
        static int getPrimaryDiagonal(int[][] arr, int bounds)
        {
            int index = 0;
            int sum = 0;

            // STARTING AT INDEX [0][0]
            for (int counter = 0; counter < bounds; counter++)
            {
                sum = sum + arr[counter][index];
                index++;
            }

            // RETURN SUM
            return sum;
        }

        static int getSecondaryDiagonal(int[][] arr, int bounds)
        {
            int index = bounds - 1;
            int sum = 0;

            // STARTING AT INDEX [0][BOUNDS - 1]
            for (int counter = 0; counter < bounds; counter++)
            {
                sum = sum + arr[counter][index];
                index--;
            }

            // RETURN SUM
            return sum;
        }
    }
}
