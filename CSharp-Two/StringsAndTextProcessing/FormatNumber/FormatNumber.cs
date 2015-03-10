//### Problem 11. Format number
//*	Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//*	Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine( "Decimal: {0}".PadRight(15), number );
        Console.WriteLine("Hexadecimal: {0}".PadRight(15), Convert.ToString(number, 16));
        Console.WriteLine("Percentage {0:0.0%}".PadRight(15), number);
        Console.WriteLine("Scientific notation: {0:E2}".PadRight(15), number);
    }
}