//### Problem 8. Maximal sum
//*	Write a program that finds the sequence of maximal sum in given array.

//_Example:_

//|                 input               |    result   |
//|-------------------------------------|-------------|
//| 2, 3, -6, -1, **2, -1, 6, 4**, -8, 8| 2, -1, 6, 4 |

//*	_Can you do it with only one loop (with single scan through the elements of the array)?_

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element({0}): ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int maxSum = 0;
        int maxPrevSum = 0;
        int begin = 0;
        int end = 0;
        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            if (maxPrevSum < maxSum)
            {
                begin = i;
            }
            maxPrevSum = maxSum;
            for (int j = i; j < n; j++)
            {
                currentSum += arr[j];
                if (currentSum > maxSum)
                {
                    end = j;
                    maxSum = currentSum;
                }
            }
        }

        Console.Write(arr[begin - 1]);
        for (int i = begin; i <= end; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }
}