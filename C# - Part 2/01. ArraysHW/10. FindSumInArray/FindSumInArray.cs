//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:
//array	                    S	        result
//4, 3, 1, 4, 2, 5, 8       11	        4, 2, 5

using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum: ");
        int sum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} numbers: ", n);
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;
        int currentSum = 0;
        string numbers = "";

        for (int i = 0; i < n && isEqual; i++)
        {
            currentSum = arr[i];
            numbers = arr[i] + " ";
            for (int j = i + 1; j < n && isEqual; j++)
            {
                currentSum += arr[j];
                numbers += arr[j] + " ";

                if (currentSum == sum)
                {
                    Console.WriteLine("The sequence of numbers that equals the sum is: {0}", numbers);
                    isEqual = false;
                }
            }
        }

        if (isEqual)
        {
            Console.WriteLine("There is no sequence of numbers that equals the sum.");
        }

    }
}
