//### Problem 4. Multiplication Sign
//*	Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//*	Use a sequence of `if` operators.

//_Examples:_

//| a    | b    | c    | result |
//|------|------|------|:------:|
//| 5    | 2    | 2    | +      |
//| -2   | -2   | 1    | +      |
//| -2   | 4    | 3    | -      |
//| 0    | -2.5 | 4    | 0      |
//| -1   | -0.5 | -5.1 | -      |

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Sign: 0");
            return;
        }
        else if ( (a < 0 && b < 0 && c < 0) ||
                  (a < 0 && b > 0 && c > 0) ||
                  (a > 0 && b < 0 && c > 0) ||
                  (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("Sign: -");
        }
        else
        {
            Console.WriteLine("Sign: +");
        }
    }
}

/*
 * a < 0; b < 0; c < 0 => -
 * a < 0; b < 0; c > 0 => +
 * etc
 */