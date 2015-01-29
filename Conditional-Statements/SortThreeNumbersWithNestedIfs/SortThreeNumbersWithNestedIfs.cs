//### Problem 7. Sort 3 Numbers with Nested Ifs
//*	Write a program that enters 3 real numbers and prints them sorted in descending order.
//*	Use nested `if` statements.

//_Note: Don’t use arrays and the built-in sorting functionality._

//_Examples:_

//| a    | b    | c    |     result     |
//|------|------|------|----------------|
//| 5    | 1    | 2    | 5 2 1          |
//| -2   | -2   | 1    | 1 -2 -2        |
//| -2   | 4    | 3    | 4 3 -2         |
//| 0    | -2.5 | 5    | 5 0 -2.5       |
//| -1.1 | -0.5 | -0.1 | -0.1 -0.5 -1.1 |
//| 10   | 20   | 30   | 30 20 10       |
//| 1    | 1    | 1    | 1 1 1          |

using System;

class SortThreeNumbersWithNestedIfs
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

        if (a >= b)
        {
            if (b >= c)
            {
                biggestNumber = a;    
            }
            else
            {
                if (a >= c)
                {
                    biggestNumber = a;
                }
                else
                {
                    biggestNumber = c;
                }
            }
        }
        else
        {
            if (a >= c)
            {
                biggestNumber = b;
            }
            else
            {
                if (b >= c)
                {
                    biggestNumber = b;
                }
                else
                {
                    biggestNumber = c;
                }
            }
        }
        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}
