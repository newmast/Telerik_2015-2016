//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
//Examples:

//n	  Odd?
//3	  true
//2	  false
//-2  false
//-1  true
//0	  false

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int input = int.Parse(Console.ReadLine());

        bool odd = (input % 2 == 1);

        Console.WriteLine("Odd? " + odd);
    }
}