//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        Console.Write("Enter number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + Factorial(n));
    }

    static BigInteger Factorial(BigInteger n)
    {
        BigInteger result = 1;

        for (BigInteger i = 0; i < n; i++)
        {
            result *= (i + 1);
        }

        return result;
    }
}
