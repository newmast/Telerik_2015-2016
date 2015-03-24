using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    class Program
    {
        static void Main()
        {
            var numbers = new[] { 1, 42, 3, 2163, 5, 14, 21, 51, 104, 9 };

            //With lambda
            var divisibles = numbers.Where(x => (x % 21 == 0));
            Console.Write("With lambda: ");
            foreach (var number in divisibles)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //With Linq
            divisibles = from number in numbers
                         where (number % 21 == 0)
                         select number;

            Console.Write("With LINQ: ");
            foreach (var number in divisibles)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
