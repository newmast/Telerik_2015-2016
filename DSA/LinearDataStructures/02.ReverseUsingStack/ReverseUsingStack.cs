namespace ReverseUsingStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseUsingStack
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            var reversedNumbers = ReverseNumbers(numbers);

            for (int i = 0; i < reversedNumbers.Count; i++)
            {
                Console.Write(reversedNumbers[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        private static IList<int> ReverseNumbers(IList<int> numbers)
        {
            var numberStack = new Stack<int>();

            numbers.ToList().ForEach(n => numberStack.Push(n));

            var reversedNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                reversedNumbers.Add(numberStack.Pop());
            }

            return reversedNumbers;
        }
    }
}
