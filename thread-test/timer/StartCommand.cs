using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class StartCommand : Command
    {
        public StartCommand(IDictionary<string, Timer> timers, string timerName) : base(timers, timerName)
        {
        }

        public override void Execute()
        {
            Execute(timer => timer.Start());
        }
    }
}
