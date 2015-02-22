using System;
using Convert;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string n = Console.ReadLine();
        Console.WriteLine(Converter.ConvertBase(n, 2, 16));
    }
}