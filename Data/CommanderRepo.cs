using System.Collections.Generic;
using System.Linq;
using net_rest.Models;

namespace net_rest.Data
{
    public class CommanderRepo : ICommanderRepo
    {
        private CommanderContext _context;

        public CommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
