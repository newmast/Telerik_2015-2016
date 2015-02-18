//### Problem 1. Fill the matrix
//*	Write a program that fills and prints a matrix of size `(n, n)` as shown below:
//http://puu.sh/fZvIw/a98ed29bd1.png

using System;

class FillTheMatrix
{
    static int n = 0;
    static int[,] matrix;

    static void Main()
    {
        Console.Write("Enter matrix size: ");
        n = int.Parse(Console.ReadLine());

        matrix = new int[n, n];

        Console.Write("Choose algorithm (a, b, c, d): ");
        char choice = char.Parse(Console.ReadLine());

        switch (choice)
        {
            case 'a':
                choiceA();
                break;  
            case 'b':
                choiceB();
                break;
            case 'c':
                choiceC();
                break;
            case 'd':
                choiceD();
                break;  
            default:
                Console.WriteLine("Enter a valid choice!");
                return;
        }
        printMatrix();
    }

    private static void choiceD()
    {
        Console.WriteLine("Not implemented.");
        Environment.Exit(0);
    }

    private static void choiceC()
    {
        int cellValue = 1;
        int rowSubstitute = 0;

        for (int row = n - 1; row >= 0; row--)
        {
            rowSubstitute = row;
            for (int col = 0; col < n - row; col++)
            {
                matrix[rowSubstitute++, col] = cellValue++;
            }
        }

        cellValue = n * n;

        for (int row = 0; row < n - 1; row++)
        {
            rowSubstitute = row;
            for (int col = n - 1; rowSubstitute >= 0; col--)
            {
                matrix[rowSubstitute--, col] = cellValue--;
            }
        }
    }

    private static void choiceB()
    {
        int cellValue = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
	        {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = cellValue;
                    cellValue++;
                }
	        }
            else
	        {
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j, i] = cellValue;
                    cellValue++;
                }
	        }
        }
    }

    private static void choiceA()
    {
        int cellValue = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = cellValue;
                cellValue++;
            }
        }
    }
    private static void printMatrix()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
