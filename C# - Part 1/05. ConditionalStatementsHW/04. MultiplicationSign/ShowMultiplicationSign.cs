//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
using System.Threading;
using System.Globalization;
class ShowMultiplicationSign
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

        if (a > 0 && b > 0 && c > 0)
        {
            object result = '+';
            Console.WriteLine("The sign is: {0}.", result);
        }

        else if (a < 0 && b < 0 && c < 0)
        {
            object result = '-';
            Console.WriteLine("The sign is: {0}.", result);
        }

        else if (a == 0 || b == 0 || c == 0)
        {
            object result = '0';
            Console.WriteLine("The sign is: {0}.", result);
        }

        else if ((a < 0 && b > 0 && c > 0) ||
                 (a > 0 && b < 0 && c > 0) ||
                 (a > 0 && b > 0 && c < 0))
        {
            object result = '-';
            Console.WriteLine("The sign is: {0}.", result);
        }

        else if ((a < 0 && b < 0 && c > 0) ||
                (a < 0 && b > 0 && c < 0) ||
                (a > 0 && b < 0 && c < 0))
        {
            object result = '+';
            Console.WriteLine("The sign is: {0}.", result);        
        }

    }
}