//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class CheckIfDigitIs7
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int a = int.Parse(Console.ReadLine());
        if ((a / 100) % 10 == 7)
        {
            Console.WriteLine("The third digit from right-to-left is 7.");
        }

        else
        {
            Console.WriteLine("The third digit from right-to-left is not 7.");
        }
    }
}