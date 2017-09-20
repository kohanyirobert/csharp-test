using System;
using System.Collections.Generic;

namespace ThreadTest
{
    public sealed class CommandFactory
    {
        private readonly IDictionary<string, Timer> timers;

        public CommandFactory(IDictionary<string, Timer> timers)
        {
            this.timers = timers;
        }

        public Command getCommand(string commandName, string timerName)
        {
            switch (commandName)
            {
                case "exit":
                    return new ExitCommand(timers, timerName);
                case "new":
                    return new NewCommand(timers, timerName);
                case "start":
                    return new StartCommand(timers, timerName);
                case "stop":
                    return new StopCommand(timers, timerName);
                case "kill":
                    return new KillCommand(timers, timerName);
                case "status":
                    return new StatusCommand(timers, timerName);
                default:
                    throw new ArgumentException(String.Format("Unknown command {0}", commandName));
            }
        }
    }
}
