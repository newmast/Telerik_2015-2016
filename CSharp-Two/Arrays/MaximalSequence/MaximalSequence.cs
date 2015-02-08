//### Problem 4. Maximal sequence 
//*	Write a program that finds the **maximal sequence** of equal elements in an array.

//_Example:_

//|              input              | result  |
//|---------------------------------|---------|
//| 2, 1, 1, 2, 3, 3, **2, 2, 2**, 1 | 2, 2, 2 |

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int firstElement = 0;
        int secondElement = 0;
        bool firstTime = true;

        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                if (firstTime)
                {
                    firstTime = false;
                    firstElement = i;
                }
                else
                {
                    secondElement = i;
                }
            }
            else
            {
                firstTime = true;
            }
        }

        Console.WriteLine("Longest Sequence: ");
        for (int i = firstElement; i <= secondElement + 1; i++)
        {
            Console.Write("{0}", numbers[i]);
        }
        Console.WriteLine();
    }
}
