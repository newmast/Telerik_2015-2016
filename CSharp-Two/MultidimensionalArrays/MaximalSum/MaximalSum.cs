//### Problem 2. Maximal sum
//*	Write a program that reads a rectangular matrix of size `N x M` and finds in it the square `3 x 3` that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter height >= 3: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter width >= 3: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
                Console.Write("[{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
			}
            Console.WriteLine();
		}

        if (n < 3 || m < 3)
        {
            Console.WriteLine("Incorrect input.");
            return;
        }

        int currentSum = 0;
        int maxSum = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                currentSum = 0;
                for (int counter = i; counter < 3; counter++)
                {
                    for (int counter2 = 0; counter2 < 3; counter2++)
                    {
                        currentSum += matrix[counter, counter2];
                    }
                }
                if (currentSum >= maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        Console.WriteLine("The maximal sum is: " + maxSum);
    }
}