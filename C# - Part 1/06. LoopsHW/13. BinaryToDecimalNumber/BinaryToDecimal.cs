//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string inputBinary = Console.ReadLine();
        int count = inputBinary.Length;

        long decN = 0;

        for (int i = 0; i < inputBinary.Length; i++)
        {
            long separateNumber = long.Parse(inputBinary[i].ToString());
            decN += separateNumber * (long)Math.Pow(2, count - 1 - i);
        }
        Console.WriteLine("Decimal number is " + decN);

    }
}