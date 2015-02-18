//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
//that has maximal sum of its elements.

using System;
class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                int element = int.Parse(Console.ReadLine());
                matrix[row, col] = element;
            }
        }

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine("The max sum is from numbers: ");
        Console.WriteLine("{0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
        Console.WriteLine("The max sum is: " + maxSum);
    }
}