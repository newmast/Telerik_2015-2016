namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Shape
    {
        private float width;
        private float height;

        public Shape(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public float Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public virtual float CalculateSurface()
        {
            return 0f;
        }
    }
}
