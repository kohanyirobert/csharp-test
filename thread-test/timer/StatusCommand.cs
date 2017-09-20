using System;
using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class StatusCommand : Command
    {
        public StatusCommand(IDictionary<string, Timer> timers, string timerName) : base(timers, timerName)
        {
        }

        public override void Execute()
        {
            Execute(timer => Console.WriteLine("Timer {0} at {1} seconds", timer.Name, timer.Seconds));
        }
    }
}
