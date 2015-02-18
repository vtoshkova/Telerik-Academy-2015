//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter number of chars in first array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of chars in second array: ");
        int m = int.Parse(Console.ReadLine());

        bool isSame = true;

        if (n == m)
        {
            Console.WriteLine("Enter {0} chars of first array: ", n);
            char[] firstArray = new char[n];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} chars of second array: ", m);
            char[] secondArray = new char[m];
            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = char.Parse(Console.ReadLine());
            }

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