//### Problem 5.	Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//*	Write a program that, for a given two integer numbers `n` and `x`, calculates the sum `S = 1 + 1!/x + 2!/x2 + … + n!/x^n`.
//*	Use only one loop. Print the result with `5` digits after the decimal point.

//_Examples:_

//| n           | x          | S       |
//|-------------|------------|---------|
//| 3           | 2          | 2.75000 |
//| 4           | 3          | 2.07407 |
//| 5           | -4         | 0.75781 |

using System;

class FactorialSum
{
    static void Main()
    {
        Console.Write("Enter the first number (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number (x): ");
        int x = int.Parse(Console.ReadLine());

        double sum = 0;
        double factorized = 1;
        double toPower = 0;

        for (int i = 1; i <= n; i++)
        {
            factorized *= i;
            toPower = Math.Pow(x, i);
            sum += factorized / toPower;
        }
        sum++;
        Console.WriteLine("The sum is: {0:F5}", sum);
    }
}