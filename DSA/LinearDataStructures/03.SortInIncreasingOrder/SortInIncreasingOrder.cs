namespace SortInIncreasingOrder
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class SortInIncreasingOrder
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            numbers.Sort();
            numbers.ForEach(n => Console.Write(n + " "));

            Console.WriteLine();
        }
    }
}
