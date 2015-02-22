//### Problem 9.* Binary floating-point
//*	Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type `float`).

//_Example:_

//| number | sign | exponent |         mantissa        |
//|:------:|:----:|:--------:|:-----------------------:|
//| -27,25 | 1    | 10000011 | 10110100000000000000000 |

using System;
using System.IO;
using System.Text;

class BinaryFloatingPoint
{
    static void Main()
    {
        Console.Write("Enter a floating-point number: ");
        float number = float.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation: " + ToBinaryString(number));
    }
    static string ToBinaryString(float value)
    {

        int bitCount = sizeof(float) * 8;
        char[] result = new char[bitCount]; 

        int intValue = System.BitConverter.ToInt32(BitConverter.GetBytes(value), 0);

        for (int bit = 0; bit < bitCount; ++bit)
        {
            int maskedValue = intValue & (1 << bit);
            if (maskedValue > 0)
                maskedValue = 1;
            {
                result[bitCount - bit - 1] = maskedValue.ToString()[0];
            }
        }
        if (value < 0)
        {
            result[0] = '1';
        }
        else
        {
            result[0] = '0';
        }
        return new string(result);
    }
}