//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
//by 7 and 5 at the same time.

using System;
class DivisionBy7and5
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 7 == 0 && a % 5 == 0)
        {
            Console.WriteLine("The number can be divided to 7 and 5.");
        }
        
        else
        {
            Console.WriteLine("The number cannot be divided to 7 and 5.");
        }

    }
}