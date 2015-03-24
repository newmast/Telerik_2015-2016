using System;

namespace Coordinates3D
{
    static class DistanceCalculator
    {
        public static double TwoPoints(Point3D pointOne, Point3D pointTwo)
        {
            double xDistance = Math.Pow(pointTwo.X - pointOne.X, 2);
            double yDistance = Math.Pow(pointTwo.Y - pointOne.Y, 2);
            double zDistance = Math.Pow(pointTwo.Z - pointOne.Z, 2);

            return Math.Sqrt(xDistance + yDistance + zDistance);
        }
    }
}
