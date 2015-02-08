/*
 Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

using System;

class CalculateAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter the date of your birth (Format: DD/MM/YYYY):");
        string[] inputDate = Console.ReadLine().Split('/');

        int birthDay = int.Parse(inputDate[0]);
        int birthMonth = int.Parse(inputDate[1]);
        int birthYear = int.Parse(inputDate[2]);

        int futureAge = 0;

        DateTime current = DateTime.Today;

        if (birthMonth == current.Month)
        {
            if (birthDay <= current.Day)
            {
                futureAge = 2014 - birthYear + 11;
            }
        }
        else if (birthMonth < current.Month)
        {
            futureAge = 2014 - birthYear + 11;
        }
        else
        {
            futureAge = 2014 - birthYear + 10;
        }

        Console.WriteLine("After 10 years you will be: " + futureAge);
    }
}