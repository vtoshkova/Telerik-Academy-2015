//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization;
class PlayWithNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine(@"Please choose an option:
1 -> int
2 -> double
3 -> string");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: Console.Write("Please enter an int: ");
                int a = int.Parse(Console.ReadLine());
                int aResult = a + 1;
                Console.WriteLine("Result is: {0}.", aResult); break;
            case 2: Console.Write("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                double bResult = b + 1;
                Console.WriteLine("Result is: {0}.", bResult); break;
            case 3: Console.Write("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine("Result is: {0}*.", c); break;
            default: Console.WriteLine("Invalid choice.");break;
        }
    }
}