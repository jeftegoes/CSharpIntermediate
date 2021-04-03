using System;
using System.Collections;

namespace Section4BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            // This is generate System.InvalidCastException
            // var numberErr = (int) list[1];

            int number = 10;
            object obj1 = number;
            // or
            object obj2 = 10;

            // Umboxing
            object obj3 = 10;
            int anotherNumber = (int) obj3;
        }
    }
}
