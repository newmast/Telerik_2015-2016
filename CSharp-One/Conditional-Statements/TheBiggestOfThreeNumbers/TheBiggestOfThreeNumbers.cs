//### Problem 5. The Biggest of 3 Numbers
//*	Write a program that finds the biggest of three numbers.

//_Examples:_

//| a    | b    | c    | biggest |
//|------|------|------|:-------:|
//| 5    | 2    | 2    | 5       |
//| -2   | -2   | 1    | 1       |
//| -2   | 4    | 3    | 4       |
//| 0    | -2.5 | 5    | 5       |
//| -0.1 | -0.5 | -1.1 | -0.1    |

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        float c = float.Parse(Console.ReadLine());

        float biggestNumber = 0;

        if (a >= c && a >= b)
        {
            biggestNumber = a;
        }
        else if (b >= a && b >= c)
        {
            biggestNumber = b;
        }
        else
        {
            biggestNumber = c;
        }

        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}
