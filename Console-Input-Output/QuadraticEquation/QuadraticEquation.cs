//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:

//a	    b	    c	    roots
//2	    5	    -3	    x1=-3; x2=0.5
//-1	3	    0	    x1=3; x2=0
//-0.5	4	    -8	    x1=x2=4
//5	    2	    8	    no real roots

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter the coefficient a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient c: ");
        float c = float.Parse(Console.ReadLine());

        float x1 = 0;
        float x2 = 0;
        float discriminant = b*b - 4*a*c;
        float discriminantsSqrt = (float) Math.Sqrt(discriminant);
        if (a == 0)
        {
            x1 = -(c / b);
            x2 = x1;

            Console.WriteLine("The roots are: ");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
            return; // stops the program
        }

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots.");
            return;
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("x1 = x2 = " + ( (-b)/(2*a) ) );
            return;
        }

        x1 = ((-b) - discriminantsSqrt) / (2 * a);
        x2 = ((-b) + discriminantsSqrt) / (2 * a);

        Console.WriteLine("The roots are: ");
        Console.WriteLine("x1 = " + x1);
        Console.WriteLine("x2 = " + x2);
    }
}
