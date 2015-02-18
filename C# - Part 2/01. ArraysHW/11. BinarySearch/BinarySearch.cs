//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers: ", n);
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.Write("Enter searched number: ");
        int searchedIndex = int.Parse(Console.ReadLine());

        int start = 0;
        int end = arr.Length - 1;
        int index = 0;

        while ((end - start) > 1)
        {
            index = start + (end - start) / 2;

            if (arr[index] == searchedIndex)
            {
                Console.WriteLine("Searched number is on index [{0}].", index);
                return;
            }

            else if (arr[index] > searchedIndex)
            {
                end = index;
            }

            else if (arr[index] < searchedIndex)
            {
                start = index;
            }

        }
        Console.WriteLine("Number not found!");

    }
}