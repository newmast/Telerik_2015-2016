using System;
using Convert;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string n = Console.ReadLine();
        Console.WriteLine(Converter.ConvertBase(n, 16, 2));
    }
}