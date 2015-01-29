//### Problem 6. The Biggest of Five Numbers
//*	Write a program that finds the biggest of five numbers by using only five if statements.

//_Examples:_

//| a    | b    | c    |  d |   e  | biggest |
//|------|------|------|:--:|:----:|---------|
//| 5    | 2    | 2    | 4  | 1    | 5       |
//| -2   | -22  | 1    | 0  | 0    | 1       |
//| -2   | 4    | 3    | 2  | 0    | 4       |
//| 0    | -2.5 | 0    | 5  | 5    | 5       |
//| -3   | -0.5 | -1.1 | -2 | -0.1 | -0.1    |

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        float e = float.Parse(Console.ReadLine());

        float biggestNumber = 0;

        if (a >= b &&
            a >= c &&
            a >= d &&
            a >= e)
        {
            biggestNumber = a;
        }
        else if (b >= a &&
            b >= c &&
            b >= d &&
            b >= e)
        {
            biggestNumber = b;
        }
        else if (c >= a &&
            c >= b &&
            c >= d &&
            c >= e)
        {
            biggestNumber = c;
        }
        else if (d >= a &&
            d >= b &&
            d >= c &&
            d >= e)
        {
            biggestNumber = d;
        }
        else if (e >= a &&
            e >= b &&
            e >= c &&
            e >= d)
        {
            biggestNumber = d;
        }

        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}
