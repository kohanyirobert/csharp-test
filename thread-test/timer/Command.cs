using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreadTest
{
    public abstract class Command
    {
        protected readonly IDictionary<string, Timer> timers;
        protected readonly string timerName;

        protected delegate void Action(Timer timer);

        protected Command(IDictionary<string, Timer> timers, string timerName)
        {
            this.timerName = timerName;
            this.timers = timers;
        }

        public abstract void Execute();

        protected void Execute(Action action)
        {
            if (timerName == null)
            {
                foreach (var timer in timers.Values.ToList())
                {
                    action(timer);
                }
            }
            else
            {
                if (timers.ContainsKey(timerName))
                {
                    action(timers[timerName]);
                }
                else
                {
                    Console.WriteLine("Unknown timer {0}", timerName);
                }
            }
        }
    }
}
