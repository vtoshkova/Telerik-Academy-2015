//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
class CheckPointsInACircle
{
    static void Main()
    {
        Console.Write("Please enter the value \"x\" of the point.");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value \"y\" of the point.");
        int numberB = int.Parse(Console.ReadLine());
        // Math Formula: (x-a)(x-a) + (y-b)(y-b) = r.r, but a=0, b=0, r=2 => x.x + y.y = 4
        int unitCircle = 4;

        bool isItInside = (Math.Pow(numberA, 2) + Math.Pow(numberB, 2) <= unitCircle);
        Console.WriteLine("The point is inside the circle: " + isItInside);
    }
}