//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
//each on a single line.

using System;
class Numbers1ToN
{
    static void Main()
    {
        Console.Write("Enter a number bigger than 1: ");
        double a = double.Parse(Console.ReadLine());
        int b = Convert.ToInt32(a);

        if (b >= 1)
        {
            for (int i = 1; i <= b; i++)
                Console.WriteLine(i);
        }

        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
}