//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

using System;
using System.Threading;
using System.Globalization;
class FindBiggestN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is: {0}.", a);
        }

        else if (b > a && b > c)
        {
            Console.WriteLine("The biggest number is: {0}.", b);        
        }

        else if (c > a && c > b)
        {
            Console.WriteLine("The biggest number is: {0}.", c);
        }
    }
}