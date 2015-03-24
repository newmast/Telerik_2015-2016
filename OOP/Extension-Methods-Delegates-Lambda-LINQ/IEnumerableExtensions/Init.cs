//### Problem 2. IEnumerable extensions
//*	Implement a set of extension methods for `IEnumerable<T>` that implement the following group functions: 
//* sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;

    class Init
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Sum: " + arr.Sum());
            Console.WriteLine("Product: " + arr.Product());
            Console.WriteLine("Min: " + arr.Min());
            Console.WriteLine("Max: " + arr.Max());
            Console.WriteLine("Average: " + arr.Average());
        }
    }
}
