//### Problem 7. Selection sort
//*	**Sorting** an array means to arrange its elements in increasing order. Write a program to sort an array.
//*	Use the [Selection sort](http://en.wikipedia.org/wiki/Selection_sort) algorithm: 
//* Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter an array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
		{
            Console.Write("Element[{0}]: ", i);
            a[i] = int.Parse(Console.ReadLine());
		}

        int min = 0;

        for (int i = 0; i < n - 1; i++)
        {
            min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (a[j] < a[min])
                {
                    min = j;
                }
            }

            if (min != i)
            {
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}
