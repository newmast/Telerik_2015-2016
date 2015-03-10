//### Problem 6. Sum integers
//*	You are given a sequence of positive integer values written into a string, separated by spaces.
//*	Write a function that reads these values from given string and calculates their sum.

using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        string numberString = Console.ReadLine();
        SumIntegerValues(numberString);
    }

    private static void SumIntegerValues(string numberString)
    {
        int[] numbers = numberString
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum is: " + sum);
    }
}