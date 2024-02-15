using Command.Service.Interface;
using Utils.Entities;

namespace Command.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        public BaseService() { }

        public Task<T> CreateAsync(T entity, string userName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
