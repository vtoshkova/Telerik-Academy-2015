//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and 
//using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter number of elements in array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers: ", n);
        int[] arr = new int [n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        int maxValue = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= k)
            {
                maxValue = arr[i];
            }
        }

        Array.BinarySearch(arr, maxValue);
        if (arr[0] > k)
        {
            Console.WriteLine("There is no number smaller than K.");
        }

        else
        {
            Console.WriteLine("Greatest number closer to K and smaller than K is: " + maxValue);
        }
    }
}