﻿//Problem 5. Boolean Variable
//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

using System;
class DeclareBooleanVariable
{
    static void Main()
    {
        bool isFemale = true;
        Console.Write("Am I female? - ");
        Console.WriteLine(isFemale ? "Yes" : "No");
    }
}