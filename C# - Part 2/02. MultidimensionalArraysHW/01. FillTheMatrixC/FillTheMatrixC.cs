/*Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n):
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10*/

using System;
class FillTheMatrixC
{
    static void Main()
    {
        Console.Write("Enter number of rows and columns: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int rows = 0;
        int cols = 0;
        int digit = 1;

        for (int row = n - 1; row >= 0; row--)
        {
            rows = row;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = digit++;
            }

        }

        for (int row = 0; row < n; row++)
        {
            rows = row;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = digit++;
            }
        }


        for (rows = 0; rows < n; rows++)
        {
            for (cols = 0; cols < n; cols++)
            {
                Console.Write("{0, 5}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}