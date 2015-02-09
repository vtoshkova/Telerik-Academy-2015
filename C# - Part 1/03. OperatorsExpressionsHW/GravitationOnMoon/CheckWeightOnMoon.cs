﻿//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
class CheckWeightOnMoon
{
    static void Main()
    {
        Console.Write("What is your weight in kilograms? ");
        int a = int.Parse(Console.ReadLine());
        double weight = a * 17.0 / 100;
        Console.WriteLine("Your weight on the moon will be {0} kg.", weight);
    }
}