using System;
using System.Text;

namespace Coordinates3D
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly Point3D centerPoint;

        public Point3D(double x, double y, double z) 
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            centerPoint = new Point3D(0, 0, 0);
        }

        public static Point3D CenterPoint
        {
            get { return centerPoint; }
        }
        
        public override string ToString()
        {
            StringBuilder printer = new StringBuilder();

            printer.AppendLine(this.X + " " + this.Y + " " + this.Z);

            return printer.ToString();
        }
    }
}
