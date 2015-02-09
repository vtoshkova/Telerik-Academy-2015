//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).


//Saw the easier solution... oh, well... at least it works :) 

using System;

class DefinePointToCircleAndRectangle
{
    static void Main()
    {
        Console.Write("Please give the value \"x\" of the point.");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please give the value \"y\" of the point.");
        double b = double.Parse(Console.ReadLine());

        bool unitCircle = ((a - 1) * (a - 1) + (b - 1) * (b - 1)) < 1.5 * 1.5;

        //The point is outside the rectangle if the area of the triangles is bigger than the area of the triangle.
        //Coordinates: Ax, Ay = 1, -1; Bx, By = 7, -1; Cx, Cy = 7, -3; Dx, Dy = 1, -3; Px, Py = a, b
        //Triangle formula area: (Ax(By-Py) + Bx(Py-Ay) + Px(Ay-By))/2
        double rectangleArea = 6 * 2;
        double ABP = Math.Abs(((1 * (-1 - b)) + (7 * (b - (-1))) + (a * (-1 - (-1)))) / 2);
        double BCP = Math.Abs(((7 * (-3 - b)) + (7 * (b - (-1))) + (a * (-1 - (-3)))) / 2);
        double CDP = Math.Abs(((7 * (-3 - b)) + (1 * (b - (-3))) + (a * (-3 - (-3)))) / 2);
        double DAP = Math.Abs(((1 * (-1 - b)) + (1 * (b - (-3))) + (a * (-3 - (-1)))) / 2);

        bool rectangle = (ABP + BCP + CDP + DAP) > rectangleArea;
        bool result = unitCircle && rectangle;
        
        Console.WriteLine("The point is inside the circle and outside the rectangle: {0}.", result);

    }
}