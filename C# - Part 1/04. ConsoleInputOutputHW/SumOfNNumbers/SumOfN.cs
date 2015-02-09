//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;
class SumOfN
{
    static void Main()
    {
        Console.Write("Enter the count of numbers: ");
        double countA = double.Parse(Console.ReadLine());
        double sum = 0;

        for (double i = 1; i <= countA; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            double countI = double.Parse(Console.ReadLine());
            sum += countI;
        }

        Console.WriteLine("Their sum is {0}.", sum);
    }
}