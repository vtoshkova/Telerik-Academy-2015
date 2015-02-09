/*Problem 9. Matrix of Numbers
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
like in the examples below. Use two nested loops.
n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7*/

using System;
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter a number between 1 and 20: ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 1 && a <= 20)
        {
            for (int row = 1; row <= a; row++)
            {
                for (int column = row; column <= row + a - 1; column++)
                {
                    Console.Write("{0,2} ", column);
                }
                Console.WriteLine();
            }
        }
    }
}