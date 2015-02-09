//Problem 11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;
class RandomNsInRange
{
    static void Main()
    {
        Console.Write("Enter a positive n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max value not equal to min value: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();

       if (n > 0 && min != max)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", rnd.Next(min, max + 1));
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}