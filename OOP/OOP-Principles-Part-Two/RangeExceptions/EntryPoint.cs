namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static void Main()
        {
            Console.Write("Enter a number in the range 1..100: ");
            int input = int.Parse(Console.ReadLine());

            if (input < 1 ||
                input > 100)
            {
                throw new InvalidRangeException<int>("Invalid input!", 1, 100);
            }

            Console.WriteLine("Enter a date in the range 1.1.1980 ... 12.31.2013 (Format: MM/DD/YYYY): ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            if (inputDate < new DateTime(1981, 1, 1) ||
                inputDate > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("Invalid input!", new DateTime(1981, 1, 1), new DateTime(2013, 12, 31));
            }
            Console.WriteLine("Input was correct.");
        }
    }
}
