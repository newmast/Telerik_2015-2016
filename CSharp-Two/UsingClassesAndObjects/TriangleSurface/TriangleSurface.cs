//### Problem 4. Triangle surface
//*	Write methods that calculate the surface of a triangle by given:
//    *	Side and an altitude to it;
//    *	Three sides;
//    *	Two sides and an angle between them;
//*	Use `System.Math`.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Choose to calculate area by: ");
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle between them.");
        int choice = int.Parse(Console.ReadLine());

        Console.Clear();

        switch (choice)
        {
            case 1:
                SideAndAltitude();
                break;
            case 2:
                ThreeSides();
                break;
            case 3:
                TwoSidesAndAngle();
                break;
            default:
                Console.WriteLine("Enter a valid option.");
                break;
        }
    }

    private static void TwoSidesAndAngle()
    {
        Console.Write("Enter first triangle side: ");
        float sideOne = float.Parse(Console.ReadLine());
        Console.Write("Enter second triangle side: ");
        float sideTwo = float.Parse(Console.ReadLine());
        Console.Write("Enter triangle angle: ");
        float angle = float.Parse(Console.ReadLine());

        double area = 0.5 * sideOne * sideTwo * Math.Sin(angle);

        Console.WriteLine("Area is: " + area);
    }

    private static void ThreeSides()
    {
        Console.Write("Enter first triangle side: ");
        float sideOne = float.Parse(Console.ReadLine());
        Console.Write("Enter second triangle side: ");
        float sideTwo = float.Parse(Console.ReadLine());
        Console.Write("Enter third triangle side: ");
        float sideThree = float.Parse(Console.ReadLine());

        float semiperimeter = (sideOne + sideTwo + sideThree) / 2;

        double area = Math.Sqrt(semiperimeter * (semiperimeter - sideOne) * (semiperimeter - sideTwo) * (semiperimeter - sideThree));
        Console.WriteLine("Area is: " + area);
        return;
    }

    private static void SideAndAltitude()
    {
        Console.Write("Enter triangle side: ");
        float side = float.Parse(Console.ReadLine());
        Console.Write("Enter triangle altitude: ");
        float altitude = float.Parse(Console.ReadLine());

        float area = (side * altitude) / 2;
        Console.WriteLine("Area is: " + area);
        return;
    }
}