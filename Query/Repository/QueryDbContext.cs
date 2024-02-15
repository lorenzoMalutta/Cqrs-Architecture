using Microsoft.EntityFrameworkCore;
using Utils.EntityFramework;

namespace Query.Repository
{
    public class QueryDbContext : BaseDbContext
    {
        public QueryDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }
    }
}
