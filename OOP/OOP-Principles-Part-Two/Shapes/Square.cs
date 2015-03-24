namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square : Shape
    {
        public Square(float side)
            : base(side, side)
        {
        }

        public override float CalculateSurface()
        {
            return this.Height * Width;
        }
        public override string ToString()
        {
            return "Square";
        }
    }
}
