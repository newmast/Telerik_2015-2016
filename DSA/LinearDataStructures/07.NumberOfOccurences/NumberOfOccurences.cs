namespace NumberOfOccurences
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberOfOccurences
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var numberCounts = GetNumberOfOccurences(numbers);

            foreach (var pair in numberCounts)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value + " times.");
            }
        }

        private static IDictionary<int, int> GetNumberOfOccurences(IList<int> numbers)
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

            return occurences;
        }
    }
}
