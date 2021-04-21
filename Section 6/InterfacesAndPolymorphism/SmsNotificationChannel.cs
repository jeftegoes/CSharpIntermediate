using System;

namespace Section6InterfacesAndPolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}