﻿//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

using System;
class PlayWithFourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a four-digit number that doesn't start with 0: ");
        int abcd = int.Parse(Console.ReadLine());

        int a = (abcd / 1000) % 10;
        int b = (abcd / 100) % 10;
        int c = (abcd / 10) % 10;
        int d = abcd  % 10;

        Console.WriteLine("The number is {0}{1}{2}{3}.", a, b, c, d);
        int sum = a + b + c + d;
        Console.WriteLine("The sum of its digits is: {0}.", sum);
        Console.WriteLine("The number in reversed order is {0}{1}{2}{3}.", d, c, b, a);
        Console.WriteLine("If we put the last digit in first position the number will be {0}{1}{2}{3}.", d, a, b, c);
        Console.WriteLine("If we exchange the second and the third digits, the number will be {0}{1}{2}{3}.", a, c, b, d);

    }
}