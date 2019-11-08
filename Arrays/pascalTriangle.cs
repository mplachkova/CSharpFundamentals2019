using System;

namespace pascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //The triangle may be constructed in the following manner:
            //In row 0(the topmost row), there is a unique nonzero entry 1.
            //Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0.
            //Print each row elements separated with whitespace.

            int rows = int.Parse(Console.ReadLine());
            int[] nextRow;
            int[] currentRow;
            Console.WriteLine(1);
            if (rows == 1)
            {
                return;
            }
            currentRow = new int[2];
            currentRow[0] = 1;
            currentRow[1] = 1;
            Console.WriteLine(string.Join(" ", currentRow));
            if (rows == 2)
            {
                return;
            }
            else
            {
                for (int j = 3; j <= rows; j++)
                {
                    nextRow = new int[currentRow.Length + 1];
                    nextRow[0] = 1;
                    nextRow[nextRow.Length - 1] = 1;

                    for (int k = 1; k < nextRow.Length - 1; k++)
                    {
                        nextRow[k] = currentRow[k - 1] + currentRow[k];
                    }
                    Console.WriteLine(string.Join(" ", nextRow));
                    currentRow = nextRow;
                }
            }
        }
    }
}
