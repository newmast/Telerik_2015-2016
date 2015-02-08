//### Problem 10. Find sum in array
//*	Write a program that finds in given array of integers a sequence of given sum `S` (if present).

//_Example:_

//|        array            |  S |  result |
//|-------------------------|----|---------|
//| 4, 3, 1, **4, 2, 5**, 8 | 11 | 4, 2, 5 |

using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter sum to find: ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element({0}): ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            currentSum = 0;
            for (int j = i; j < n; j++)
            {
                currentSum += arr[j];
                if (currentSum == sum)
                {
                    found = true;
                    break;
                }
            }
        }
        if (found)
        {
            Console.WriteLine("The sum CAN be found.");
        }
        else
        {
            Console.WriteLine("The sum CAN'T be found.");
        }
    }
}
/*

11
7
4
3
1
4
2
5
8

*/