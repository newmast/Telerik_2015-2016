//### Problem 9. Sorting array
//*	Write a method that return the maximal element in a portion of array of integers starting at given index.
//*	Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int arrLength = int.Parse(Console.ReadLine());

        int[] values = new int[arrLength];

        for (int i = 0; i < values.GetLength(0); i++)
        {
            Console.Write("[{0}]: ", i);
            values[i] = int.Parse(Console.ReadLine());
        }
        SortArrayDescending(values);
        SortArrayAscending(values);
        
    }
    static int GetMaxStartingFrom( int begin, int[] values)
    {
        int max = values[begin];
        for (int i = begin + 1; i < values.GetLength(0); i++)
        {
            if (values[i] >= max)
            {
                max = values[i];
            }
        }
        return max;
    }

    static void SortArrayDescending(int[] values)
    {
        for (int i = 0; i < values.GetLength(0); i++)
        {
            int temp2 = GetMaxStartingFrom(i, values);
            int temp = Array.IndexOf(values, temp2);
            values[temp] = values[i];
            values[i] = temp2;

        }
        Console.Write("Descending order: ");
        for (int i = 0; i < values.GetLength(0); i++)
        {
            Console.Write(values[i] + " ");
        }
        Console.WriteLine();
    }

    static void SortArrayAscending(int[] values)
    {
        int[] valuesReversed = values.Reverse().ToArray();
        Console.Write("Ascending order: ");
        for (int i = 0; i < valuesReversed.GetLength(0); i++)
        {
            Console.Write(valuesReversed[i] + " ");
        }
        Console.WriteLine();
    }
}
