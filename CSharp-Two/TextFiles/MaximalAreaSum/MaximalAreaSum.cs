//### Problem 5. Maximal area sum
//*	Write a program that reads a text file containing a square matrix of numbers.
//*	Find an area of size `2 x 2` in the matrix, with a maximal sum of its elements.
//    *	The first line in the input file contains the size of matrix `N`.
//    *	Each of the next `N` lines contain `N` numbers separated by space.
//    *	The output should be a single number in a separate text file.

//_Example:_

//| input |                                               | output |
//|-------|                                               |--------|
//| 4 <br> 2 3 3 4 <br> 0 2 3 4 <br> 3 7 1 2 <br> 4 3 3 2 |   17   |

using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        int matrixSize;
        int[,] matrix;

        using (StreamReader reader = new StreamReader("../../TextFile1.txt"))
        {
            matrixSize = int.Parse(reader.ReadLine());
            matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string[] currentRow = reader.ReadLine().Split(' ');

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(currentRow[j]);
                }
            }
        }
        int currentSum = 0;
        int maxSum = 0;
        for (int i = 0; i < matrixSize - 1; i++)
        {
            for (int j = 0; j < matrixSize - 1; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if (currentSum >= maxSum)
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }
        }
        Console.WriteLine("Maximal sum is: " + maxSum);
    }
}