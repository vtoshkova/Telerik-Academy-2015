//Problem 2. Bonus Score
//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;
using System.Threading;
using System.Globalization;
class ApplyBonusScore
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Please enter a number between 1 and 9: ");
        double a = double.Parse(Console.ReadLine());

        if (a >= 1 && a <= 3)
        {
            double result = a * 10;
            Console.WriteLine("The result is: {0}.", result);
        }
        
        else if (a >= 4 && a <= 6)
        {
            double result = a * 100;
            Console.WriteLine("The result is: {0}.", result);
        }

        else if (a >= 7 && a <= 9)
        {
            double result = a * 1000;
            Console.WriteLine("The result is: {0}.", result);        
        }

        else if (a < 1 || a > 9)
        {
            Console.WriteLine("Invalid score.");
        }
    }
}