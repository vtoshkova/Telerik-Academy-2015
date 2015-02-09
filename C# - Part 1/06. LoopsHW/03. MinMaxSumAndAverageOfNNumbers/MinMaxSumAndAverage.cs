/*Problem 3. Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;
class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.WriteLine("Numbers to be entered: ");
        int n = int.Parse(Console.ReadLine());

        int input;
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int sum = 0;
        double average;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            input = int.Parse(Console.ReadLine());

            sum += input;
            if (input > maxValue)
            {
                maxValue = input;
            }

            if (input < minValue)
            {
                minValue = input;
            }

        }
        average = sum / n;
        Console.WriteLine("The min value is {0}, max value is {1}, sum is {2} and average is {3:0.00}.",
            minValue, maxValue, sum, average);
    }
}