//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;
class PrintIsoscelesTriangle
{
    static void Main()
    {

        char symbol = '\u00A9';
        Console.WriteLine("    {0} \n \n   {1} {2} \n \n  {3}   {4} \n \n {5} {6} {7} {8}",
            symbol, symbol, symbol, symbol, symbol, symbol, symbol, symbol, symbol);

    }

}