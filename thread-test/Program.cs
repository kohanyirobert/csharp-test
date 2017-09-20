using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreadTest
{
    public class Program
    {
        private static readonly IDictionary<string, Timer> TIMERS = new SortedDictionary<string, Timer>();
        private static readonly CommandFactory COMMAND_FACTORY = new CommandFactory(TIMERS);

        internal static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter one of the available commands: new {name}, start [{name}], stop [{name}], delete [{name}], status [{name}])");

                string line = Console.ReadLine();

                string[] parts = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0)
                {
                    Console.WriteLine("Invalid input: {0}", line);
                    continue;
                }

                string commandName = parts[0];
                string timerName = null;
                if (parts.Length >= 2)
                {
                    timerName = parts[1];
                }

                try
                {
                    COMMAND_FACTORY.getCommand(commandName, timerName).Execute();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
