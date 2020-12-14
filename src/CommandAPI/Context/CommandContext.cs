using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Context
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CommandModel> Commands { get; set; }
    }
}