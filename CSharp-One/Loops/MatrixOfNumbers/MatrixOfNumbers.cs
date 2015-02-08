//### Problem 9.	Matrix of Numbers
//*	Write a program that reads from the console a positive integer number `n` (1 &#8804; n &#8804; 20) and 
//* prints a matrix like in the examples below. Use two nested loops.

//_Examples:_

//n = 2	matrix	n = 3	matrix	 n = 4	 matrix
//      1 2			    1 2 3	 		 1 2 3 4
//      2 3			    2 3 4	 		 2 3 4 5
//                      3 4 5	 		 3 4 5 6
//                                       4 5 6 7

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter value n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] numberMatrix = new int[n, n];

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                numberMatrix[i, j] = i + j + 1;
                Console.Write(numberMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
