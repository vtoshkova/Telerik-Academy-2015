//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
class CalculateRectangles
{
    static void Main()
    {
        Console.Write("Please define rectangle's width in cm: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please define rectangle's height in cm: ");
        int b = int.Parse(Console.ReadLine());

        int perimeter = (a + b) * 2;
        int area = a * b;

        Console.WriteLine("The perimeter of the rectangle is {0} cm and its area is {1} cm2.", perimeter, area);
    }
}