using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2));
    }
}
