using Command.Repository;
using Command.Service.Interface;
using Utils.Entities;

namespace Command.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly ICommandRepository<T> _repository;

        public BaseService(ICommandRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<T> CreateAsync(T entity, string userName)
        {
            var response = _repository.CreateAsync(entity, userName);

            return response;
        }

        public Task DeleteAsync(T entity)
        {
            var response = _repository.DeleteAsync(entity);

            return response;
        }

        public Task<T> UpdateAsync(T entity, string userName)
        {
            var response = _repository.UpdateAsync(entity, userName);

            return response;
        }
    }
}
