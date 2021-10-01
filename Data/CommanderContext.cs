using Microsoft.EntityFrameworkCore;
using net_rest.Models;

namespace net_rest.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) { }
        
        // Add more DB Contexts here
        public DbSet<Command> Commands { get; set; }
    }
}
