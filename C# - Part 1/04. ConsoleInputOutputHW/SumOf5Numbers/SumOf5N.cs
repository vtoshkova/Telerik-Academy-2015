//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
class SumOf5N
{
    static void Main()
    {
        Console.Write("Enter 5 numbers in a single line separated by a space: ");
        string[] tokens = Console.ReadLine().Split();

        double a = double.Parse(tokens[0]);
        double b = double.Parse(tokens[1]);
        double c = double.Parse(tokens[2]);
        double d = double.Parse(tokens[3]);
        double e = double.Parse(tokens[4]);
        double sum = a + b + c + d + e;

        Console.WriteLine("The sumber of the number is: {0}.", sum);


    }
}