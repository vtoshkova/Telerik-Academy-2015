//Problem 17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;
class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        long a = long.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        long b = long.Parse(Console.ReadLine());
        long remainder;
        long divisor = 0;


        if (a > b)
        {
            while (b > 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            divisor = a;
        }

        else
        {
            while (a > 0)
            {
                remainder = b % a;
                b = a;
                a = remainder;
            }
            divisor = b;
        }

        Console.WriteLine("GCD is " + divisor);
    }

}