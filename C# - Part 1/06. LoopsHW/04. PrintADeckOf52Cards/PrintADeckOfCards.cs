/*Problem 4. Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/

using System;
class PrintADeckOfCards
{
    static void Main()
    {
        Console.WriteLine("The deck of cards consists of: ");

        for (int number = 2; number <= 10; number++)
        {
            Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", number, number, number, number);
        }

        string[] ranks = { "J", "Q", "K", "A" };
        for (int card = 0; card <= 3; card++)
        {
            Console.WriteLine("{0} of spades, {1} of clubs, {2} of hearts, {3} of diamonds", ranks[card], ranks[card], ranks[card], ranks[card]);
        }

    }
}