using System;
using System.Threading;

namespace Section2Exercise1
{
    public class Stopwatch
    {
        private TimeSpan Duration { get; set; } = new TimeSpan(0, 0, 0);

        public void Start()
        {
            var timespan = new TimeSpan(0, 0, 0);
            do
            {
                timespan += Duration.Add(TimeSpan.FromMilliseconds(1));

                //Thread.Sleep(TimeSpan.FromMilliseconds(1));

                if (timespan.Seconds == 1)
                {
                    Duration = timespan;
                    break;
                }
            }
            while(true);
        }

        public TimeSpan Stop()
        {
            return this.Duration;
        }
    }
}