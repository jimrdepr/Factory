using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Circle : GeometricShapes
    {
        public void Draw()
        {
            Console.WriteLine("Circle has been drawn");
        }
    }
}
