//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
//ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariableTypes
{
    static void Main()
    {
        ushort cars = 52130;
        sbyte trucks = -115;
        int bikes = 4825932;
        byte ships = 97;
        short airplanes = -10000;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", cars, trucks, bikes, ships, airplanes);
        
    }
}