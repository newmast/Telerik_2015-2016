// Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
// and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter key [k]: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int result = 0;
        int final = 0;

        while (true)
        {
            result = Array.BinarySearch(numbers, k);
            if (result < 0)
            {
                k--;
            }
            else
            {
                final = result;
                break;
            };
        }
        Console.WriteLine("Result: {0}", numbers[result]);
    }
}