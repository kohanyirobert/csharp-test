using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class StopCommand : Command
    {
        public StopCommand(IDictionary<string, Timer> timers, string timerName) : base(timers, timerName)
        {
        }

        public override void Execute()
        {
            Execute(timer => timer.Stop());
        }
    }
}
