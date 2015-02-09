//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;
class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Your integer is? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("You need the value of bit number...? ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool bitValue = bit == 1;
        Console.WriteLine("The value of bit number {0} is 1: {1}.", p, bitValue);
    }
}