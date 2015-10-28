namespace MajorantOfArray
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class MajorantOfArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var majorant = GetArrayMajorant(numbers);

            if (majorant == null)
            {
                Console.WriteLine("Array has not majorant.");
            }
            else
            {
                Console.WriteLine("Majorant: " + majorant);
            }
        }

        private static int? GetArrayMajorant(IList<int> numbers)
        {
            var occurences = new Dictionary<int, int>();
            var bestValue = 0;
            var bestKey = 0;

            foreach (var number in numbers)
            {
                if (!occurences.ContainsKey(number))
                {
                    occurences.Add(number, 0);
                }

                occurences[number]++;

                if (occurences[number] > bestValue)
                {
                    bestValue = occurences[number];
                    bestKey = number;
                }
            }

            if (bestValue < numbers.Count/2 + 1)
            {
                return null;
            }

            return bestKey;
        }
    }
}
