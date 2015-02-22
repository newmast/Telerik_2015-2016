//### Problem 8. Binary short
//*	Write a program that shows the binary representation of given 16-bit signed integer number (the C# type `short`).

using System;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        short number = short.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine(new string('0', 16));
            return;
        }

        StringBuilder binary = new StringBuilder();

        for (int bit = 0; bit < 16; bit++)
        {
            binary.Insert(0, (number >> bit) & 1);
        }
        Console.WriteLine("Binary representation: " + binary);
    }
}