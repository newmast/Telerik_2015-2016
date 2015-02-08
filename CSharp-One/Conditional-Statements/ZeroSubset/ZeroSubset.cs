//### Problem 12.* Zero Subset
//*	We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//*	Assume that repeating the same subset several times is not a problem.

//_Examples:_

//| numbers       | result                |
//|---------------|-----------------------|
//| 3  -2  1  1 8 | -2 + 1 + 1 = 0        |
//|               |                       |
//| 3 1 -7 35 22  | no zero subset        |
//|               |                       |
//| 1 3 -4 -2 -1  | 1 + -1 = 0            |
//|               | 1 + 3 + -4 = 0        |
//|               | 3 + -2 + -1 = 0       |
//|               |                       |
//| 1 1 1 -1 -1   | 1 + -1 = 0            |
//|               | 1 + 1 + -1 + -1 = 0   |
//|               |                       |
//| 0 0 0 0 0     | 0 + 0 + 0 + 0 + 0 = 0 |

//_Hint: you may check for zero each of the 31 subsets with 31 `if` statements._

using System;

class ZeroSubset
{
    static void Main()
    {
        int count = 0;
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter value for number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= 31; i++)
        {
            int sum = 0;
            for (int j = 0; j <= 5; j++)
            {
                int mask = 1 << j;
                int bit = (i & mask) >> j;
                if (bit == 1)
                {
                    sum += numbers[j];
                }
            }
            if (sum == 0)
            {
                count++;
            }
        }
        Console.WriteLine("{0} subsets have sum = 0!", count);
    }
}
