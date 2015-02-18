﻿//Problem 3. Sequence n matrix• We are given a matrix of strings of size  N x M . Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//• Write a program that finds the longest sequence of equal strings in the matrix.
//Example:
//matrix
//ha fifi ho hi 
//fo ha hi xx 
//xxx ho ha xx 
//result ha, ha, ha  
//s qq s 
//pp pp s 
//pp qq s 
//result s, s, s

using System;

class SequenceNmatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("[{0}, {1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
            Console.WriteLine();
        }
        int maxCounter = 0;
        int counter = 1;
        string longestSequence = "";

        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col < m; col++)
            {
                if (matrix[row, col] == matrix[row, col - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    maxCounter = counter;
                    longestSequence = matrix[row, col];
                }
            }
            counter = 1;
        }

        counter = 1;

        for (int col = 0; col < m; col++)
        {
            for (int row = 1; row < n; row++)
            {
                if (matrix[row, col] == matrix[row - 1, col])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    maxCounter = counter;
                    longestSequence = matrix[row, col];
                }
            }
            counter = 1;
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                counter = 1;
                for (int i = row, j = col; i < (n - 1) && (j < m - 1); i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }

                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        longestSequence = matrix[i, j];
                    }
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = m - 1; col >= 0; col--)
            {
                counter = 1;
                for (int i = row, j = col; i < (n - 1) && (j > 0); i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        counter++;
                    }

                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        longestSequence = matrix[i, j];
                    }
                }
            }

        }

        if (maxCounter > 1)
        {
            Console.Write(longestSequence);
            for (int i = 1; i < maxCounter; i++)
            {
                Console.Write(", " + longestSequence);
            }
            Console.WriteLine();
        }
    } 
}