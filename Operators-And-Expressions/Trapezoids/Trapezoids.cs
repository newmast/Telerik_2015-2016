﻿//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

//Examples:
//a	        b	        h	        area
//5         7	        12	        72
//2         1	        33	        49.5
//8.55	    4.3	        2.7	        17.28
//100       200	        300	        45000
//0.222     0.333	    0.555	    0.1540125

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter a value for a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for h: ");
        float h = float.Parse(Console.ReadLine());

        float result = ((a + b) / 2) * h;

        Console.WriteLine(result);
    }
}
