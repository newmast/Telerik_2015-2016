using System;
using Coordinates3D;

class Init
{
    static void Main()
    {
        PointPaths path = new PointPaths();
        path.AddPoints( new Point3D(1, 2, 3));
        path.AddPoints( new Point3D(4, 5, 6));
        path.AddPoints( new Point3D(7, 8, 9));
        PathStorage.Save("../../Paths.txt", path);

        PointPaths loadedPath = PathStorage.Load("../../Paths.txt");
    }
}