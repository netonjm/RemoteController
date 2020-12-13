using System;
using System.Windows.Forms;

namespace RemoteController.Client
{
    class WinFormsTimer : ITimer
    {
        readonly Timer timer;
        public WinFormsTimer ()
        {
            timer = new Timer();
            timer.Tick += (s,e) => Tick?.Invoke(this, EventArgs.Empty);
        }

        public int Interval {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        public event EventHandler Tick;

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
