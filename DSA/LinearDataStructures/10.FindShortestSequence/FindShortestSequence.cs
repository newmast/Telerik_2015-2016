namespace FindShortestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindShortestSequence
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            var n = int.Parse(Console.ReadLine());

            Console.Write("Enter m: ");
            var m = int.Parse(Console.ReadLine());

            var sequence = GetShortestSequence(n, m);
            PrintQueue(sequence);
        }

        private static IList<int> GetShortestSequence(int n, int m)
        {
            var transformations = new List<int>();

            if (n > m)
            {
                throw new ArgumentException("No such sequence exception.");
            }

            var currentSequenceValue = m;

            while (currentSequenceValue > n)
            {
                transformations.Add(currentSequenceValue);

                if (currentSequenceValue / 2 >= n)
                {
                    currentSequenceValue /= 2;
                } 
                else if (currentSequenceValue - 2 >= n)
                {
                    currentSequenceValue -= 2;
                }
                else if (currentSequenceValue - 1 >= n)
                {
                    currentSequenceValue -= 1;
                }

                Console.WriteLine(currentSequenceValue);
            }

            transformations.Add(n);
            return transformations;
        }
        private static void PrintQueue(IList<int> numbers)
        {
            var length = numbers.Count;

            for (int i = length - 1; i >= 0; i--)
            {
                var info = numbers[i] + (i == 0 ? string.Empty : " -> ");
                Console.Write(info);
            }

            Console.WriteLine();
        }
    }
}
