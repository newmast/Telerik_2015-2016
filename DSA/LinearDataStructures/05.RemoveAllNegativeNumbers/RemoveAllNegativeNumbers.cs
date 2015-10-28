namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveAllNegativeNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var nonNegativeNumbers = RemoveNegatives(numbers);

            for (int i = 0; i < nonNegativeNumbers.Count; i++)
            {
                Console.Write(nonNegativeNumbers[i] + " ");
            }

            Console.WriteLine();
        }

        private static IList<int> RemoveNegatives(List<int> numbers)
        {
            return numbers.FindAll(n => n >= 0);
        }
    }
}
