using System;
using Convert;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string n = Console.ReadLine();
        Console.WriteLine(Converter.ConvertBase(n, 16, 10)); 
    }
}