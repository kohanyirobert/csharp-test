using System;
using System.Threading;

namespace ThreadTest
{
    public sealed class Timer
    {
        public string Name { get; private set; }
        public int Seconds { get; private set; }

        private bool stopped;
        private Thread thread;

        public Timer(string name)
        {
            Name = name;
        }

        public void Start()
        {
            stopped = false;
            thread = new Thread(() =>
            {
                while (!stopped)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    Seconds++;
                }
            });
            thread.Start();
        }

        public void Stop()
        {
            stopped = true;
        }
    }
}
