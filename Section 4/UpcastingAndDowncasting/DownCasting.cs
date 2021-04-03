using System;

namespace Section4UpcastingAndDowncasting
{
    public class DownCasting
    {
        public DownCasting()
        {
            var shape = new Shape();
            Text t = shape as Text;

            // in this context, variable: t is null.
            if (t != null)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Operation downcasting with oprator AS invalid.");
            }

            var text = new Text();
            Shape s = text; // Implicit UpCasting

            if (s is Text)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Operation downcasting with oprator IS invalid.");
            }
        }
        
    }
}