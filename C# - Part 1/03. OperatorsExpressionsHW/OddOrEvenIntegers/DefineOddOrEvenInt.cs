//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;
class DefineOddOrEvenInt
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}