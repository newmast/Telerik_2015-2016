//### Problem 18.* Remove elements from array
//*	Write a program that reads an array of integers and removes from it a minimal number of elements 
//* in such a way that the remaining array is sorted in increasing order.
//*	Print the remaining sorted array.

//_Example:_

//|           input                               |     result    |
//|:---------------------------------------------:|:-------------:|
//| 6, **1**, 4, **3**, 0, **3**, 6, **4**, **5** | 1, 3, 3, 4, 5 |

using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        int?[] arr = new int?[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 2; i++)
        {
            if (arr[i] != null)
            {
                if (arr[i] >= arr[i + 1])
                {
                    if (arr[i + 2] >= arr[i])
                    {
                        arr[i + 1] = null;
                    }
                    else if (i > 0)
                    {
                        if (arr[i - 1] <= arr[i])
                        {
                            arr[i] = null;
                        }
                    }
                    else
                    {
                        arr[i] = null;
                    }
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != null)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
