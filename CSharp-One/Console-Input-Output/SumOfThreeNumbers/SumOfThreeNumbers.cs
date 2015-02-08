//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a	    b	    c	    sum
//3	    4	    11	    18
//-2	0	    3	    1
//5.5	4.5	    20.     30.1

using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter a value for b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter a value for c: ");
        float c = float.Parse(Console.ReadLine());

        float result = a + b + c;

        Console.WriteLine("Their sum is: " + result);
    }
}
