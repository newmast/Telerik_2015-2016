//### Problem 7.	Calculate N! / (K! * (N-K)!)
//*	In combinatorics, the number of ways to choose `k` different members out of a group of `n` different elements (also known as the number of combinations) 
//* is calculated by the following formula:
//* N! / (K! * (N-K)!
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//*	Your task is to write a program that calculates `n! / (k! * (n-k)!)` for given `n` and `k` (1 < k < n < 100). Try to use only two loops.

//_Examples:_

//| n           | k | n! / (k! * (n-k)!) |
//|-------------|---|--------------------|
//| 3           | 2 | 3                  |
//| 4           | 2 | 6                  |
//| 10          | 6 | 210                |
//| 52          | 5 | 2598960            |

using System;

class Combinatorics
{
    static void Main()
    {
        Console.Write("Enter the first number (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number (x): ");
        int k = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;
        double factNminusK = 1;
        long answer = 0;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i; // n!

            if (i <= k) // k!
            {
                factorialK *= i;
            }

            if (i <= n - k) // (n - k)!
            {
                factNminusK *= i;
            }
        }

        answer = (long) (factorialN / (factorialK * factNminusK));
        Console.WriteLine("There are {0} possible combinations.", answer);
    }
}
