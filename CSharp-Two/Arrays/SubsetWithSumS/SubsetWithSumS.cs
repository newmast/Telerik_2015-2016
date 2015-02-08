//### Problem 16.* Subset with sum S
//*	We are given an array of integers and a number `S`.
//*	Write a program to find if there exists a subset of the elements of the array that has a sum `S`.

//_Example:_

//|       input array                      |  S  |  result |
//|:--------------------------------------:|:---:|:-------:|
//| 2, **1**, **2**, 4, 3, **5**, 2, **6** |  14 |   yes   |

using System;

class SubsetWithSumS
{
    static void Main()
    {
        Console.Write("Enter subset sum: ");
        int subset = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int currentSum = 0;
        bool found = false;
        int j = 0;
        for (int i = j; i < n; i++)
        {
            currentSum += arr[i];
            if (currentSum == subset)
            {
                found = true;
                break;
            }
            else if (currentSum > subset)
            {
                currentSum = 0;
                i = j;
                j++;
            }
        }
        if (found)
        {
            Console.WriteLine("There is a subset with such sum!");
        }
        else
        {
            Console.WriteLine("There is no subset with such sum!");
        }
    }
}
