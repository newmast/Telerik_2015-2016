//### Problem 17. Date in Bulgarian
//*	Write a program that reads a date and time given in the format: `day.month.year hour:minute:second` 
//  and prints the date and time after `6` hours and `30` minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        string format = "d.M.yyyy H:m:s";
        CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");

        Console.WriteLine("Enter a date in the bulgarian format: ");
        DateTime dateBG = DateTime.Parse(Console.ReadLine());

        dateBG = dateBG.AddMinutes(390);

        Console.WriteLine(dateBG);
    }
}
