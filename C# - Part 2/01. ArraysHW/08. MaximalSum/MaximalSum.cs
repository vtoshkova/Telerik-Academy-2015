//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input	                                 result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	     2, -1, 6, 4

using System;
class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers: ", n);
        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }

        int firstIndex = 0;
        int lastIndex = 0;
        int tempIndex = 0;
        double maxSum = 0;
        double currentSum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            currentSum += arr[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                lastIndex = i;
                firstIndex = tempIndex;
            }

            if (currentSum <= 0)
            {
                currentSum = 0;
                tempIndex = i + 1;
            }
        }

        Console.Write("The sequence of max sum is:");
        for (int i = firstIndex; i <= lastIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}