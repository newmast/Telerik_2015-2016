﻿//### Problem 14.	Decimal to Binary Number
//*	Using loops write a program that converts an integer number to its binary representation.
//*	The input is entered as long. The output should be a variable of type string.
//*	Do not use the built-in .NET functionality.

//_Examples:_

//| decimal           | binary                       |
//|-------------------|------------------------------|
//| 0                 | 0                            |
//| 3                 | 11                           |
//| 43691             | 1010101010101011             |
//| 236476736         | 1110000110000101100101000000 |

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        int remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Its binary representation: " + result);
    }
}
