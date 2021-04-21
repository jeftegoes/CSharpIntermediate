using System;

namespace Section5MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}