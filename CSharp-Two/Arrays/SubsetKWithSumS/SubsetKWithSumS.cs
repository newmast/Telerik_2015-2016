//### Problem 17.* Subset K with sum S
//*	Write a program that reads three integer numbers `N`, `K` and `S` and an array of `N` elements from the console.
//*	Find in the array a subset of `K` elements that have sum `S` or indicate about its absence.

using System;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter subset sum: ");
        int subset = int.Parse(Console.ReadLine());
        Console.Write("Enter amount of elements to look for the subset: ");
        int k = int.Parse(Console.ReadLine());
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

        for (int i = 0; i < n; i++)
        {
            if (found)
            {
                break;
            }
            found = false;
            currentSum = 0;
            for (int j = i; j < k + i; j++)
            {
                currentSum += arr[j];
            }
            if (currentSum == subset)
            {
                found = true;
                break;
            }
            else if (currentSum > subset)
            {
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("There is a subset of {0} elements with such sum!", k);
        }
        else
        {
            Console.WriteLine("There is no subset of {0} elements with such sum!", k);
        }
    }
}
