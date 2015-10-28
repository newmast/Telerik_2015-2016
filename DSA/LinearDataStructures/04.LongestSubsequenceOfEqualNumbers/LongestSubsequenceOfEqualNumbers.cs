namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequenceOfEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var longestSubsequence = GetLongestEqualSubsequence(numbers);

            for (int i = 0; i < longestSubsequence.Count; i++)
            {
                Console.Write(longestSubsequence[i] + " ");
            }

            Console.WriteLine();
        }

        public static IList<int> GetLongestEqualSubsequence(IList<int> numbers)
        {
            var encounters = new Dictionary<int, int>();
            var bestKey = 0;
            var bestValue = 0;

            foreach (var number in numbers)
            {
                if (!encounters.ContainsKey(number))
                {
                    encounters.Add(number, 0);    
                }

                encounters[number]++;
                if (encounters[number] > bestValue)
                {
                    bestValue = encounters[number];
                    bestKey = number;
                }
            }

            return Enumerable.Repeat(bestKey, bestValue).ToList();
        } 
    }
}
