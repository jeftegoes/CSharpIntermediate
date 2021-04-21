using System;
using System.Collections.Generic;

namespace Section5MethodOverriding
{
    public class Canvas
    {
        public void DrawnShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}