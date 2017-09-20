using System;
using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class NewCommand : Command
    {
        public NewCommand(IDictionary<string, Timer> timers, string timerName) : base(timers, timerName)
        {
        }

        public override void Execute()
        {
            if (timerName == null)
            {
                Console.WriteLine("Missing timer name");
            }
            else
            {
                timers.Add(timerName, new Timer(timerName));
            }
        }
    }
}
