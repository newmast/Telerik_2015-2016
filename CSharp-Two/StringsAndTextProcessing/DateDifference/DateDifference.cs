//### Problem 16. Date difference
//*	Write a program that reads two dates in the format: `day.month.year` and calculates the number of days between them.

//_Example:_

//    Enter the first date: 27.02.2006
//    Enter the second date: 3.03.2006
//    Distance: 4 days

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string format = "d.M.yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, provider);

        Console.WriteLine("Enter the second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, provider);

        Console.WriteLine("Distances: " + Math.Abs((firstDate - secondDate).TotalDays) + " days.");
    }
}