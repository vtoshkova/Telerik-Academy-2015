//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter your numbers separated by space: ");
        string[] inputNumbers = Console.ReadLine().Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            int separateNumber = int.Parse(inputNumbers[i]);
            if (i % 2 == 0)
            {
                evenProduct *= separateNumber;
            }
            else
            {
                oddProduct *= separateNumber;
            }

        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("The even product is equal to the odd product: {0}.", evenProduct);
        }
        else
        {
            Console.WriteLine("The even product {0} is not equal to the odd product {1}.", evenProduct, oddProduct);

        }
    }
}