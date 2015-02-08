//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width	height	perimeter	area
//3	    4	    14	        12
//2.5	3	    11	        7.5
//5	    5	    20	        25

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        float height = float.Parse(Console.ReadLine());

        float perimeter = 2 * (width + height);
        float area = width * height;

        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}", area);
    }
}

