//Problem 14. Quick sort

//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }

            while (numbers[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void SortQuick(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                SortQuick(arr, left, pivot - 1);

            if (pivot + 1 < right)
                SortQuick(arr, pivot + 1, right);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        SortQuick(arr, 0, n - 1);

        Console.WriteLine("The array sorted using Quick Sort:");

        Console.Write(arr[0]);
        for (int i = 1; i < n; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }
}
