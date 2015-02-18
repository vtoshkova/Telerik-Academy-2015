//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter number of integers in first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers of first array: ", n);
        int[] firstArray = new int[n];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number of integers in second array: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers of second array: ", m);
        int[] secondArray = new int[m];
        for (int j = 0; j < secondArray.Length; j++)
        {
            secondArray[j] = int.Parse(Console.ReadLine());
        }

        bool isSame = true;

        if (n == m)
        {
            for (int k = 0; k < firstArray.Length; k++)
            {
                if (firstArray[k] == secondArray[k])
                {
                    Console.WriteLine("Elements [{0}] of both arrays are equal.", k);
                }
                else
                {
                    isSame = false;
                    Console.WriteLine("Elements [{0}] of both arrays are different.", k);
                }
            }
        }
        else
        {
            isSame = false;
            Console.WriteLine("Two arrays are equal: {0}.", isSame);
        }
    }
}