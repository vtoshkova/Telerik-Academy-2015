//Problem 12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 
            'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        Console.Write("Enter word in CAPITAL letters: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                    Console.WriteLine("The index of {0} is {1}.", word[i], j);
            }
        }

    }
}