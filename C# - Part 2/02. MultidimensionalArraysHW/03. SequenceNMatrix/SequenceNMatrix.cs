/*Problem 3. Sequence n matrix
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements 
located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.
Example:
matrix	            result		   
ha 	fifi  ho  hi    ha, ha, ha
fo	 ha	  hi  xx
xxx	 ho	  ha  xx                    */

using System;
class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                string element = Console.ReadLine();
                matrix[row, col] = element;
            }
        }

        int counter = int.MinValue;
        int rowsCounter = 1;
        int colsCounter = 1;
        int diaCounter = 1;
        int rows = 0;
        int cols = 0;

        //rows sequence
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    rowsCounter++;
                    rows = row;
                    cols = col + 1;
                }

                else
                {
                    rowsCounter = 1;
                }
            }
        }


        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n - 1; row++)
            {

                if (matrix[row, col] == matrix[row + 1, col])
                {
                    colsCounter++;
                    rows = row + 1;
                    cols = col;
                }

                else
                {
                    colsCounter = 1;
                }
            }
        }

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    diaCounter++;
                    rows = row + 1;
                    cols = col + 1;
                }

                else
                {
                    diaCounter = 1;
                }

            }
        }


        if (rowsCounter > colsCounter && rowsCounter > diaCounter)
        {
            counter = rowsCounter;
        }

        else if (colsCounter > rowsCounter && colsCounter > diaCounter)
        {
            counter = colsCounter;
        }

        else if (diaCounter > rowsCounter && diaCounter > colsCounter)
        {
            counter = diaCounter;
        }

        Console.WriteLine("The longest sequence is of {0} elements consisting of {1}.", counter, matrix[rows,cols]);
    }
}