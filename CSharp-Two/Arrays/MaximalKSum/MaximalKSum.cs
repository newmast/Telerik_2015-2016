//### Problem 6. Maximal K sum
//*	Write a program that reads two integer numbers `N` and `K` and an array of `N` elements from the console.
//*	Find in the array those `K` elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
		{
            Console.Write("Enter array[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
		}

        int currentSum = 0;
        int maxSum = 0;

        for (int i = 0; i < n - k + 1; i++)
        {
            for (int j = i; j < i + k; j++)
            {
                currentSum += arr[j];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                currentSum = 0;
            }
        }
        Console.WriteLine("The K Sequence of elements has a max sum of: " + maxSum);
    }
}
