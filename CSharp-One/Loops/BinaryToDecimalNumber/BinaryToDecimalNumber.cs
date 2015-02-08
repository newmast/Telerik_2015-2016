//### Problem 13.	Binary to Decimal Number
//*	Using loops write a program that converts a binary integer number to its decimal form.
//*	The input is entered as string. The output should be a variable of type long.
//*	Do not use the built-in .NET functionality.

//_Examples:_

//| binary                       | decimal   |
//|------------------------------|-----------|
//| 0                            | 0         |
//| 11                           | 3         |
//| 1010101010101011             | 43691     |
//| 1110000110000101100101000000 | 236476736 |

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        long n = long.Parse(Console.ReadLine());
        double dec = 0;
        int strn = n.ToString().Length;
        for (int i = 0; i < strn; i++)
        {
            long lastDigit = n % 10;
            dec = dec + lastDigit * (Math.Pow(2, i));
            n = n / 10;
        }
        Console.WriteLine("Its decimal representation: " + dec);

    }
}
