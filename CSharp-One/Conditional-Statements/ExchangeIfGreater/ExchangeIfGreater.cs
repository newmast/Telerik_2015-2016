//### Problem 1. Exchange If Greater
//*	Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
//*   As a result print the values a and b, separated by a space.

//_Examples:_

//| a    | b   | result  |
//|------|-----|---------|
//| 5    | 2   | 2 5     |
//| 3    | 4   | 3 4     |
//| 5.5  | 4.5 | 4.5 5.5 |

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Before: a = " + a + "; b = " + b + ";");

        if (a > b)
        {
            double c = a;
            a = b;
            b = c;

        }

        Console.WriteLine("After: a = " + a + "; b = " + b + ";");

    }
}
