namespace Command.Repository
{
    public interface ICommandRepository<T>
    {
        Task<T> CreateAsync(T entity, string username);
        Task<T> UpdateAsync(T entity, string username);
        Task DeleteAsync(T entity);
    }
}
