//### Problem 3.	Min, Max, Sum and Average of N Numbers
//*	Write a program that reads from the console a sequence of `n` integer numbers and 
//* returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//*	The input starts by the number `n` (alone in a line) followed by `n` lines, each holding an integer number.
//*	The output is like in the examples below.

//_Example 1:_

//| input | output     |
//|-------|------------|
//| 3 <br> 2 <br> 5 <br> 1 | min = 1 <br> max = 5 <br> sum = 8 <br> avg = 2.67 |

//_Example 2:_

//| input | output     |
//|-------|------------|
//| 2 <br> -1 <br> 4 | min = -1 <br> max = 4 <br> sum = 3 <br> avg = 1.50 |

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of numbers: ");
        int n = int.Parse(Console.ReadLine());

        int number;
        int currentMin = 0;
        int currentMax = 0;
        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", (i+1));
            number = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                currentMin = number;
                currentMax = number;
            }

            currentMin = getMin(currentMin, number);
            currentMax = getMax(currentMax, number);
            totalSum += number;
        }
        Console.WriteLine("The smallest number is: " + currentMin);
        Console.WriteLine("The biggest number is: " + currentMax);
        Console.WriteLine("The average of all numbers is: " + (float)(totalSum / n));
    }

    static int getMin(int currentMin, int number)
    {
        return Math.Min(currentMin, number);
    }

    static int getMax(int currentMax, int number)
    {
        return Math.Max(currentMax, number);
    }

}
