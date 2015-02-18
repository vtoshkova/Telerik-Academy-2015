//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.

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
        string maxNum = "";
        string currNum = "";

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentSeq++;
                currNum += array[i] + " ";
            }
            else
            {
                if (currentSeq > longestSeq)
                {
                    longestSeq = currentSeq;
                    currNum += array[i] + " ";
                    maxNum = currNum;
                }
                currentSeq = 1;
                currNum = "";
            }

        }

        if (currentSeq > longestSeq)
        {
            currNum += array[array.Length - 1];
            maxNum = currNum;
        }

        Console.WriteLine("Maximal increasing sequence is: {0}.", maxNum);

    }
}