//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int[] nArray = new int[n];

        Random rnd = new Random();
        int counter = 0;

        while (counter < n)
        {
            //store random num 
            int random = rnd.Next(1, n);

            if (Array.IndexOf(nArray, random) <= 0)
            {
                //store random number into Array
                nArray[counter] = random;
                counter++;
            }
        }

        //output elements in Array
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(nArray[i]);
        }
        //output number of elements in Array
        Console.WriteLine(counter);
    }


}