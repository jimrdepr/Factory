using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Line : GeometricShapes
    {
        public void Draw()
        {
            Console.WriteLine("Line has been drawn");
        }
    }
}
