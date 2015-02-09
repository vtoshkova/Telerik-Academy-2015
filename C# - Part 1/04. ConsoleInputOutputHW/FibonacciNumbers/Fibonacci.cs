//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double x = double.Parse(Console.ReadLine());
        int a = Convert.ToInt32(x);
        
        int firstN = 0;
        int secondN = 1;
        int sum = 1;

        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(firstN);          
            sum = firstN + secondN;
            firstN = secondN;
            secondN = sum;
        }

    }
}