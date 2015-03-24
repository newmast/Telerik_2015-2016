namespace Coordinates3D
{
    using System;
    using System.IO;
    using System.Linq;

    static class PathStorage
    {
        public static void Save(string filePath, PointPaths path)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < path.PointList.Count; i++)
                {
                    writer.WriteLine(path.PointList[i]);
                }
            }
        }

        public static PointPaths Load(string filePath)
        {
            PointPaths path = new PointPaths();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    int[] coords = reader.ReadLine()
                                         .Split(' ')
                                         .Select(int.Parse)
                                         .ToArray();

                    path.AddPoints(new Point3D(coords[0], coords[1], coords[2]));

                    reader.ReadLine();
                }
            }
            return path;
        }
    }
}
