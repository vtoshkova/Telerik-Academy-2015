//Problem 10.* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] 
//and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time 
//if the time cannot be parsed. Note: You may need to learn how to parse dates and times.


using System;
using System.Globalization;
class CheckIfBeerTime
{
    static void Main()
    {
        Console.Write("Enter time in format 'hh:mm tt': ");
        string text = Console.ReadLine();
        string format = "hh:mm tt";
        DateTime parsedDate = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);
        DateTime open = DateTime.Parse("1:00 PM");
        DateTime close = DateTime.Parse("3:00 AM");

        if (parsedDate >= open || parsedDate <= close)
        {
            Console.WriteLine("It's beer time!");
        }

        else
        {
            Console.WriteLine("It's not beer time.");
        }
    }
}