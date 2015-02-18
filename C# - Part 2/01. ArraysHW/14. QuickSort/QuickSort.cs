//Problem 14. Quick sort
//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
class QuickSort
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

        Quicksort(arr, 0, arr.Length - 1);
        foreach (int number in arr)
        {
            Console.Write(number);
        }
    }

    static void Quicksort(int[] arr, int left, int right)
    {
        int originalLeft = left;
        int originalRight = right;
        int pivot = arr[(left + right) / 2];

        while (left < right)
        {
            while (pivot > arr[left])
            {
                left++;
            }
            while (pivot < arr[right])
            {
                right--;
            }

            if (left <= right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

        if (originalLeft < right)
        {
            Quicksort(arr, originalLeft, right);
        }

        if (left < originalRight)
        {
            Quicksort(arr, left, originalRight);
        }
    }
}