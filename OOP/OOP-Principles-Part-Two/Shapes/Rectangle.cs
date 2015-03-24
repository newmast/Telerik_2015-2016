namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle : Shape
    {
        public Rectangle(int height, int width)
            : base(height, width)
        {
        }
        public override float CalculateSurface()
        {
            return this.Height * this.Width;
        }
        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
