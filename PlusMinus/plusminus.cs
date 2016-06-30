/***********************************************************************************************************************************
 * THIS APPLICATION DEMONSTRATES THE USE OF CASTING TO AVOID DATA OVERFLOW AND MEETS THE HACKERRANK PLUS MINUS PUZZLE REQUIREMENTS *
 **********************************************************************************************************************************/

/* DIRECTIVES */ 
using System;
using System.IO;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenFile();
        }

        static void OpenFile()
        {
            try
            {
                // OPEN FILE AND READ CONTENT THEN CAST TO INTEGER
                var fileContent = File.ReadAllText(@"c:\Users\tw599\Documents\PlusMinus.txt");
                var array = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
                var numbers = array.Select(arg => int.Parse(arg)).ToList();

                // THE AMOUNT OF NUMBERS WITHIN THE FILE (TEST PURPOSES)
                int n = 6;

                // DECLARE VARIABLES TO STORE THE AMOUNT OF POSITIVE, NEGATIVE, AND ZERO NUMBERS WITHIN THE FILE
                decimal positive = 0.00000000m;
                decimal zeros = 0.0000000000m;
                decimal negative = 0.0000000000m;

                // CAST THE GENERIC ARRAY INTO A STATIC DATATYPE ARRAY
                int[] values = new int[numbers.Capacity];
                int counter = 0;
                foreach (int num in numbers)
                {
                    values[counter] = num;
                    counter++;
                }

                // FOREACH ITEM WITHIN THE ARRAY DETERMINE IF IT IS POSSITIVE, NEGATIVE OR ZERO
                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        positive = positive + 1;
                    }
                    else if (number == 0)
                    {
                        zeros = zeros + 1;
                    }
                    else if (number < 0)
                    {
                        negative = negative + 1;
                    }
                }

                // CONVERT RESULTS TO DECIMAL NUMBERS FOR GREATER PRECISION
                decimal nums = Convert.ToDecimal(n);
                decimal negativenums = Convert.ToDecimal(negative / n);

                Console.WriteLine(Math.Round((positive / n), 6));
                Console.WriteLine(Math.Round((negative / n), 6));
                Console.WriteLine(Math.Round((zeros / n), 6));
            }
            // CATCH FILE NOT FOUND EXCEPTION
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
                //return null;
            }
            // CATCH ALL OTHER EXCEPTIONS
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return null;
            }
        }
    }
}
