namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static void Main()
        {
            Shape square = new Square(5);
            Shape rectangle = new Rectangle(5, 8);
            Shape triangle = new Triangle(7, 9);

            Shape[] shapes = { square, rectangle, triangle };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString() + " surface: " +shape.CalculateSurface() );
            }
        }
    }
}
