//### Problem 13.*  Merge sort
//*	Write a program that sorts an array of integers using the [Merge sort](http://en.wikipedia.org/wiki/Merge_sort) algorithm.

using System;

class MergeSortAlgorithm
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(arr, 0, n - 1);

        Console.WriteLine("The array sorted using Merge Sort: ");

        Console.Write(arr[0]);
        for (int i = 1; i < n; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }

    static void MergeSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(input, left, middle);
            MergeSort(input, middle + 1, right);

            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
