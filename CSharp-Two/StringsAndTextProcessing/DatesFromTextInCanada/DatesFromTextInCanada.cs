//### Problem 19. Dates from text in Canada
//*	Write a program that extracts from a given text all dates that match the format `DD.MM.YYYY`.
//*	Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
class DatesFromTextInCanada
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        string format = "d.M.yyyy";
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
            Console.WriteLine(check.ToShortDateString());
        }
    }
}