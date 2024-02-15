using Microsoft.EntityFrameworkCore;
using Utils.EntityFramework;

namespace Command.Repository
{
    public class CommandDbContext : BaseDbContext
    {
        public CommandDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }
    }
}
