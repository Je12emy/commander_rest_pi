using System.Collections.Generic;
using net_rest.Models;

namespace net_rest.Data 
{
    public interface ICommanderRepo 
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);
    }
}
