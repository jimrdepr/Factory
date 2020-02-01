using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ShapeFactory
    {
        public GeometricShapes GetShape(ShapeType shape)
        {
            if (shape == ShapeType.LINES)
                return new Line();
            else if (shape == ShapeType.CIRCLE)
                return new Circle();
            else if (shape == ShapeType.RECTANGLE)
                return new Rectangle();
            else
                return null;
        }
        public enum ShapeType
        {
            LINES,
            CIRCLE,
            RECTANGLE,
            TRIANGLE
        }
    }
}
