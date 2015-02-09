//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;
class PrintNullValues
{
    static void Main()
    {
        int? number = null;
        Console.WriteLine("Printing a number with null value: " + number);
        number = 29;
        Console.WriteLine("Printing a number with value 29: " + number);

        double? anotherNumber = null;
        Console.WriteLine("This is also a number with null value: " + anotherNumber);
        anotherNumber = 3.14;
        Console.WriteLine("This is the number with the value of Pi: " + anotherNumber);
    }
}