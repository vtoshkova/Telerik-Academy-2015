//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
//at the position p from the binary representation of n while preserving all other bits in n.

using System;
class ModifyBit
{
    static void Main()
    {
        Console.Write("Your integer is? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("You need the value of bit number...? ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary code of the number is {0}.", Convert.ToString(n, 2).PadLeft(32, '0'));
        int mask = 1 << p;
        int nAndMask = n & mask;
        int v = nAndMask >> p;
        Console.WriteLine("Bit's value is: {0}.", v);

        if (v == 0)
        {
            int bitAtRight = 1 << p;
            int newValue = n | bitAtRight;
            Console.WriteLine("When we change the value, the new binary code is {0}.", Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("and the new number is: {0}.", newValue);
        }
        else if (v == 1)
        {
            int bitAtRight = ~(1 << p);
            int newValue = n & bitAtRight;
            Console.WriteLine("When we change the value, the new binary code is {0}.", Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("and the new number is: {0}.", newValue);
        }
    }
}