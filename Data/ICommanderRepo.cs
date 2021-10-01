using System.Collections.Generic;
using net_rest.Models;

namespace net_rest.Data 
{
    public interface ICommanderRepo 
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
