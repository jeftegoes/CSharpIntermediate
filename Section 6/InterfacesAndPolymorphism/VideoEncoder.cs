using System.Collections.Generic;

namespace Section6InterfacesAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly List<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            this._notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var notification in _notificationChannels)
            {
                notification.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}