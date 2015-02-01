//### Problem 1.	Numbers from 1 to N
//*	Write a program that enters from the console a positive integer `n` and 
//* prints all the numbers from `1` to `n`, on a single line, separated by a space.

//_Examples:_

//| n            | output    | 
//|--------------|-----------|
//| 3            | 1 2 3     | 
//| 5            | 1 2 3 4 5 |

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());

        Console.Write(1);

        for (int i = 2; i <= n; i++)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();
    }
}
