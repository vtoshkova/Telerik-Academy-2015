//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;
class CompareFloats
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (Math.Abs(a - b) < eps)
        {
            Console.WriteLine("The numbers are equal.");
        }

        if (Math.Abs(a - b) >= eps)
        {
            Console.WriteLine("The numbers are not equal.");
        }
    }
}