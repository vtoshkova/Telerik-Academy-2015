//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0.

using System;
using System.Collections.Generic;
class NInIntervalsDividedByN
{
    static void Main()
    {
        Console.WriteLine("Enter the first positive integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second positive integer: ");
        int b = int.Parse(Console.ReadLine());

        int result = 0;
        List<int> numbers = new List<int>();
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                result++;
                numbers.Add(i);
            }

        }

        Console.WriteLine("There {0} numbers divisible to 5.", result);
        Console.Write("Those numbers are: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }

    }
}