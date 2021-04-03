using System;

namespace Section4ConstructorsAndInheritance
{
    public class Vehicle
    {
        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle is being initialized.");
        // }
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}