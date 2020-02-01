using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Rectangle : GeometricShapes
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle has been drawn");
        }
    }
}
