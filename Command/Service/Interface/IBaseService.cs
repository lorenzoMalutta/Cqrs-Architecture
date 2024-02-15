using Utils.Entities;

namespace Command.Service.Interface
{
    public interface IBaseService<T> where T : BaseEntity
    {
        public Task<T> CreateAsync(T entity, string userName);
        public Task<T> UpdateAsync(T entity, string userName);
        public Task DeleteAsync(T entity);
    }
}
