//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime.

using System;
class CheckPrimeNumber
{
    static void Main()
    {
        Console.Write("Please enter a number between 1 and 100: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0)
        {
            Console.WriteLine("The number is prime.");
        }
       
        else
        {
            Console.WriteLine("The number is not prime.");
        }
    }
}