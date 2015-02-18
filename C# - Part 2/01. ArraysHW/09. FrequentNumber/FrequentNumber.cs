//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.
//Example:
//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)

using System;
class FrequentNumber
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

        int longestSeq = 1;
        int currentSeq = 1;
        int number = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentSeq++;
                if (currentSeq > longestSeq)
                {
                    longestSeq = currentSeq;
                    number = arr[i];
                }
            }
            else
            {
                currentSeq = 1;
            }

        }
       
            Console.WriteLine("The most repetitive number is: {0}", number);
 
    }
}