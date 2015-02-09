//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by a formula: (2n)!/(n+1)!n!
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter a chosen number n between 0 and 100: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger divident = 1;
        BigInteger divider = 1;

        if (n < 0 && n > 100)
        {
            Console.WriteLine("Invalid input!");
        }

        else //(2n)!/(n+1)!n!
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                divident *= i;
            }

            for (int j = 1; j <= n; j++)
            {
                divider *= j;
            }

            BigInteger result = divident / divider;
            Console.WriteLine("Result is " + result);
        }

    }
}