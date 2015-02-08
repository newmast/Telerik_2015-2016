//### Problem 11. Binary search
//*	Write a program that finds the index of given element in a sorted array of integers by using the [Binary search]
//(http://en.wikipedia.org/wiki/Binary_search_algorithm) algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter element you are searching for: ");
        int search = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Input should be sorted in ascending/descending order!");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool exists = false;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == search)
            {
                exists = true;
            }
        }

        if (!exists)
        {
            Console.WriteLine("There is no such number in this array.");
        }

        if (n == 1)
        {
            if (arr[0] == search)
            {
                Console.WriteLine("The number is at index 0.");
            }
            else
            {
                Console.WriteLine("There is no such number in this array.");
            }
            return;
        }

        bool ascending = arr[0] < arr[1];
        int indexer = n / 2;
        bool searching = true;
        while (searching)
        {
            if (ascending)
            {
                if (arr[indexer] > search)
                {
                    indexer -= indexer / 2;
                }
                else if (arr[indexer] < search)
                {
                    indexer += indexer / 2;
                }
                else if (indexer < 0 || indexer > n - 1)
                {
                    Console.WriteLine("There is no such number in this array.");
                    return;
                }
                else
                {
                    Console.WriteLine("The number is at index " + indexer + ".");
                    return;
                }
            }
            else
            {
                if (arr[indexer] < search)
                {
                    indexer -= indexer / 2;
                }
                else if (arr[indexer] > search)
                {
                    indexer += indexer / 2;
                }
                else if (indexer < 0 || indexer > n - 1)
                {
                    Console.WriteLine("There is no such number in this array.");
                    return;
                }
                else
                {
                    Console.WriteLine("The number is at index " + indexer + ".");
                    return;
                }
            }
        }
    }
}
