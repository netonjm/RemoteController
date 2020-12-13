using System;

namespace RemoteController
{
    public interface ITimer
    {
        int Interval { get; set; }

        event EventHandler Tick;

        void Start();
        void Stop();
    }
}
