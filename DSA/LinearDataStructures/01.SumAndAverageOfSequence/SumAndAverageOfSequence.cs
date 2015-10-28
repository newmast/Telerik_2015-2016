namespace SumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAndAverageOfSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter positive integer numbers (separated by space):");
            var numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(e => int.Parse(e))
                .ToList();

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
        }
    }
}
