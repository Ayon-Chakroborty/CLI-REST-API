using DOTNET_REST_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_REST_API.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}