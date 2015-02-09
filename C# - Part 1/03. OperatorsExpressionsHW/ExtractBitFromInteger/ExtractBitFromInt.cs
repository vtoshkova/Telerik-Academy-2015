//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class ExtractBitFromInt
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
        Console.WriteLine("The value of bit number {0} is: {1}.", p, bit);
    }
}