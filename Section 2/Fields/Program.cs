using System;

namespace Section2Fields
{
    class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer(10, "Mosh");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
