﻿//Problem 10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
//Examples:
//x	         y	        inside K & outside of R
//1          2	        yes
//2.5	     2	        no
//0          1	        no
//2.5        1	        no
//2          0	        no
//4          0	        no
//2.5        1.5	    no
//2          1.5        yes
//1          2.5        yes
//-100	     -100	    no

using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter a value for x: ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for y: ");
        float y = float.Parse(Console.ReadLine());

        if ((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2)) &&
            (x <= 2.5 && x >= -0.5) && 
            (y <= 2.5 && y > 1))
        {
            Console.WriteLine("Yes!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}
