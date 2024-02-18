namespace Command.Repository
{
    public class CommandRepository<T> : ICommandRepository<T>
    {

        private readonly CommandDbContext _context;
        public CommandRepository(CommandDbContext context) 
        {
            _context =  context;
        }
        public Task<T> CreateAsync(T entity, string username)
        {
            _context.Add(entity);
            _context.SaveChangesAsync();
            
            return Task.FromResult(entity);
        }

        public Task DeleteAsync(T entity)
        {
            _context.Remove(entity);
            _context.SaveChangesAsync();

            return Task.FromResult(entity);
        }

        public Task<T> UpdateAsync(T entity, string username)
        {
            _context.Update(entity);
            _context.SaveChangesAsync();

            return Task.FromResult(entity);
        }
    }
}
