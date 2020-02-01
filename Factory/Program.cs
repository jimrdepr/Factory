using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shape = new ShapeFactory();

            foreach (ShapeFactory.ShapeType s in Enum.GetValues(typeof(ShapeFactory.ShapeType)))
            {
                if (shape.GetShape(s) == null)
                    Console.WriteLine(s + " was not printed out");
            }
        }
    }
}
