using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            GeometricShapes shape;

            foreach (ShapeFactory.ShapeType s in Enum.GetValues(typeof(ShapeFactory.ShapeType)))
            {
                shape = factory.GetShape(s);
                if (shape == null)
                    Console.WriteLine("Shape not implemented");
                else
                    shape.Draw();
            }
        }
    }
}
