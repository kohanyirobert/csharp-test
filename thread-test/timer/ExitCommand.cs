using System;
using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class ExitCommand : Command
    {
        public ExitCommand(IDictionary<string, Timer> timers, string timerName) : base(timers, timerName)
        {
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
