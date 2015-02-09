//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long input = long.Parse(Console.ReadLine());

        string binN = "";

        while (input >= 1)
        {
            binN = (input % 2) + binN;
            input = input / 2;
        }
            Console.Write("Binary number is {0}", binN);
        
            Console.WriteLine();
    }
}