using System;
using System.Linq;

class SortStringByLength
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        string[] inputArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("[{0}]: ", i + 1);
            inputArray[i] = Console.ReadLine();
        }

        var result = inputArray.OrderBy(x => x.Length);

        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }
}