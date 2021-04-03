using System;
using Section4Amazon;

namespace Section4AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
            
            var calculator = new RateCalculator();
        }
    }
}
