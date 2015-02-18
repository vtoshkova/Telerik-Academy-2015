//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int longestSeq = 1;
        int currentSeq = 1;
        int number = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentSeq++;
                if (currentSeq > longestSeq)
                {
                    longestSeq = currentSeq;
                    number = array[i];
                }
            }
            else
            {
                currentSeq = 1;
            }

        }
        Console.Write("The maximal sequence of elements is:");

        for (int i = 1; i <= longestSeq; i++)
        {
            Console.Write(" {0}", number);
        }
        Console.WriteLine();
    }
}