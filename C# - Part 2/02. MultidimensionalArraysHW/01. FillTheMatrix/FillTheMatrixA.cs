/*Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n):
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16*/

using System;
class FillTheMatrixA
{
    static void Main()
    {
        Console.Write("Enter number of rows and columns: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int [n, n];
        int digit = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = digit;
                digit++;
            }
        }

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0, 5}", matrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}