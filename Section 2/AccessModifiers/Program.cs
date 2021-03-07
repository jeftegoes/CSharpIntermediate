using System;

namespace Section2AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1997, 11, 22));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
