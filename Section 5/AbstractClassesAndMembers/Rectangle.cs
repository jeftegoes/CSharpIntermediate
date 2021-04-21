using System;

namespace Section5AbstractClassesAndMembers
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Wants rectangle");
        }
    }
}