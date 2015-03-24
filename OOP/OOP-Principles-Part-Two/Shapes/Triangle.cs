namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Triangle : Shape
    {
        public Triangle(int height, int width)
            : base(height, width)
        {
        }
        public override float CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }
        public override string ToString()
        {
            return "Triangle";
        }
    }
}
