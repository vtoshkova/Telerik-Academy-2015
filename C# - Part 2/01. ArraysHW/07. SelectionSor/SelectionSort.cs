//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;
class SelectionSort
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

        int min = 0;
        int temp = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr [j] < arr [min])
                {
                    min = j;
                }
            }
            temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }

        Console.Write("The sorted array is:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0}", arr[i]);
        }
        Console.WriteLine();
    }
}