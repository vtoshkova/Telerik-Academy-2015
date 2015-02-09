//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.


using System;
class CompareNumbers
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        
        if (a > b)
        {
        Console.WriteLine("The greater number is a: {0}.", a);
        }

        else
        {
        Console.WriteLine("The greater number is b: {0}.", b);
        }

    }
}