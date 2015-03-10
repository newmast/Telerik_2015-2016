﻿//### Problem 1. Square root
//*	Write a program that reads an integer number and calculates and prints its square root.
//    *	If the number is invalid or negative, print `Invalid number`.
//    *	In all cases finally print `Good bye`.
//*	Use `try-catch-finally` block.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        try
        {
            if (number < 0)
            {
                throw new ArithmeticException("Invalid number");
            }
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}