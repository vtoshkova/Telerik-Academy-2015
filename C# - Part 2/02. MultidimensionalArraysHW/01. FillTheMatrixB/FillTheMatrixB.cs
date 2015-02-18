/*Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n):
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13*/

using System;
class FillTheMatrixB
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows and columns: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int digit = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }

            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[col, row] = digit;
                    digit++;
                }
            }


        }


        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}