/*Problem 7. Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations). For example, there are 2598960 ways to withdraw 5 cards out of 
a standard deck of 52 cards. 
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
Try to use only two loops.*/

using System;
using System.Numerics;
class Combinatorics
{
    static void Main()
    {
        Console.Write("Enter integer k between 1 and 100: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter integer n between 1 and 100: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger result1 = 1;
        BigInteger result2 = 1;

        if (n == 1 || k == 1 || n == k || n == 100 || k == 100 || k > n)
        {
            Console.WriteLine("Invalid input!");
        }

        else
        {
            //n! / (k! * (n-k)!)
            
            for (int i = k + 1; i <= n; i++)
            {
                result1 *= i;
            }

            for (int j = 1; j <= (n - k); j++)
            {
                result2 *= j;
            }
            BigInteger finalResult = result1 / result2;
            Console.WriteLine("The result is: " + finalResult);
        }
    }
}