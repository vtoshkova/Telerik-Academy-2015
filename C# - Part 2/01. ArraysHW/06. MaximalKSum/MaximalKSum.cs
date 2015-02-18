//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter {0} numbers: ", n);
        int[] elements = new int[n];
        for (int i = 0; i < n; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(elements);
        string numbers = "";

        for (int i = elements.Length - 1; i > elements.Length - 1 - k; i--)
        {
            numbers += elements[i] + " ";
        }

        Console.WriteLine("The elements with maximal sum are: {0}.", numbers);
    }
}