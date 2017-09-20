using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class KillCommand : Command
    {
        public KillCommand(IDictionary<string, Timer> timers, string timerName) : base(timers, timerName)
        {
        }

        public override void Execute()
        {
            Execute((timer) =>
            {
                timer.Stop();
                timers.Remove(timer.Name);
            });
        }
    }
}
