//### Problem 6.	Calculate N! / K!
//*	Write a program that calculates `n! / k!` for given `n` and `k` (1 < k < n < 100).
//*	Use only one loop.

//_Examples:_

//| n           | k          | n! / k! |
//|-------------|------------|---------|
//| 5           | 2          | 60      |
//| 6           | 5          | 6       |
//| 8           | 3          | 6720    |

using System;

class FactorialDivision
{
    static void Main()
    {
        Console.Write("Enter a value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for K (N > K!): ");
        int k = int.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }

        double answer = factorialN / factorialK;

        Console.WriteLine("{0}!/{1}! = {2}", n, k, answer);
    }
}
