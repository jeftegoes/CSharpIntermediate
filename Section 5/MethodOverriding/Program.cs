using System;
using System.Collections.Generic;

namespace Section5MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>() {
                new Circle() { Width = 100, Height = 100 },
                new Rectangle() { Width = 100, Height = 100  },
                new Triangle() { Width = 100, Height = 100  }
            };

            var canvas = new Canvas();
            canvas.DrawnShapes(shapes);
        }
    }
}
