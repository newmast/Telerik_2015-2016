//### Problem 9. Frequent number
//*	Write a program that finds the most frequent number in an array.

//_Example:_

//|                  input                                    |    result   |
//|-----------------------------------------------------------|-------------|
//| **4**, 1, 1, **4**, 2, 3, **4**, **4**, 1, 2, **4**, 9, 3 | 4 (5 times) |

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter length of array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currentCount = 0;
        int maxCount = 0;
        int currentNumber = 0;
        int freqNumber = 0;

        for (int i = 0; i < n; i++)
        {
            currentCount = 0;
            currentNumber = arr[i];
            for (int j = i; j < n; j++)
            {
                if (currentNumber == arr[j])
                {
                    currentCount++;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                freqNumber = arr[i];
            }
        }
        Console.WriteLine("The most frequent number is: {0} ({1} times)", freqNumber, maxCount);
    }
}

/*

13
4
1
1
4
2
3
4
4
1
2
4
9
3

*/