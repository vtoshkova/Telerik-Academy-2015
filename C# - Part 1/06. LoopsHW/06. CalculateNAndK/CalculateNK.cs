//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

using System;
using System.Numerics;
class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter integer k between 1 and 100: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter integer n between 1 and 100: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        if (n == 1 || k == 1 || n == k || n == 100 || k == 100 || k > n)
        {
            Console.WriteLine("Invalid input!");
        }

        else
        {

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine("N!/K! result is " + result);
        }
    }
}