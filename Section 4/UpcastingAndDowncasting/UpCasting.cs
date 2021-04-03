using System;
using System.Collections;

namespace Section4UpcastingAndDowncasting
{
    public class UpCasting
    {
        public UpCasting()
        {
            // UpCasting
            var text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            // var reader1 = new StreamReader(new MemoryStream());
            // var reader2 = new StreamReader(new StreamReader());

            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            foreach (var value in list)
            {
                Console.WriteLine("ArrayList value: {0}", value);
            }
        }
    }
}