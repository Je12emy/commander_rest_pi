using System.Collections.Generic;
using net_rest.Data;
using net_rest.Models;

namespace net_rest
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command { Id = 0, HowTo = "foo", Line = "bar", Platform = "Linux" },
                new Command { Id = 1, HowTo = "foo", Line = "bar", Platform = "Linux" },
                new Command { Id = 3, HowTo = "foo", Line = "bar", Platform = "Linux" },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "foo", Line = "bar", Platform = "Linux" };
        }
    }
}
