//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
//with 2 digits after the decimal point.

using System;
class CirclePerAndArea
{
    static void Main()
    {
        Console.Write("Please enter r:");
        double r = double.Parse(Console.ReadLine());
        double c = 2 * Math.PI * r;
        double a = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Circle's perimeter is {0:0.00} and its area is {1:0.00}.", c, a);
    }
}