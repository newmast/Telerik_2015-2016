//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	            sum
//1 2 3 4 5	            15
//10 10 10 10 10	    50
//1.5 3.14 8.2 -1 0	    11.84

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers, separated by a space: ");
        float result = 0;
        string[] fiveNumbers = Console.ReadLine().Split(' ');

        for (int i = 0; i < fiveNumbers.Length; i++)
        {
            result += float.Parse(fiveNumbers[i]);
        }

        Console.WriteLine("The result is: " + result);
    }
}
