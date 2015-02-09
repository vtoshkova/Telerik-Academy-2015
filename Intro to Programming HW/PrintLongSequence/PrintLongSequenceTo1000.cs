using System;

class PrintLongSequenceTo1000
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            Console.BufferHeight = 1001;
            Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
        }
    }
}