using System;

namespace Section5MethodOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}