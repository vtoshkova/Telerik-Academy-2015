//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and 
//solves it (prints its real roots).

using System;
class SolveQuadEquation
{
    static void Main()
    {
        //x = (-b +- sqrt(b^2 - 4ac)) / 2a
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());

        double sqrtValue = ((b * b) - (4 * a * c));

        if (sqrtValue > 0)
        {
            double x1 = (-b + Math.Sqrt(sqrtValue)) / (2 * a);
            double x2 = (-b - Math.Sqrt(sqrtValue)) / (2 * a);

            Console.WriteLine("The values of x1 and x2 are: {0} and {1}.", x1, x2);

        }

        else if (sqrtValue == 0)
        {
            double x1 = (-b + Math.Sqrt(sqrtValue)) / (2 * a);
            Console.WriteLine("The values of x1 and x2 are equal: {0}.", x1);
        }

        else if (sqrtValue < 0)
        {
            Console.WriteLine("No real roots.");
        }
    }
}