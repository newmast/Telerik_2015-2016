namespace RemoveOddCountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddCountNumbers
    {
        private static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var processedNumbers = RemoveOddCountNumbersFrom(numbers);
            foreach (var number in processedNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        private static IList<int> RemoveOddCountNumbersFrom(IList<int> numbers)
        {
            var occurences = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!occurences.ContainsKey(number))
                {
                    occurences.Add(number, 0);
                }

                occurences[number]++;
            }

            var result = new List<int>();
            foreach (var pair in occurences)
            {
                if (pair.Value%2 == 0)
                {
                    for (int i = 0; i < pair.Value; i++)
                    {
                        result.Add(pair.Key);
                    }
                }
            }

            return result;
        }
    }
}
