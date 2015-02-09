//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidsArea
{
    static void Main()
    {
        Console.Write("Please define side a of the trapezoid: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please define side b of the trapezoid: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please define the height of the trapezoid: ");
        int h = int.Parse(Console.ReadLine());
        int area = ((a + b) * h) / 2;

        Console.WriteLine("The area of the trapezoid is: {0}.", area);
    }
}