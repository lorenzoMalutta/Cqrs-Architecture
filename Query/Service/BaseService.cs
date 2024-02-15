using Query.Service.Interface;
using Utils.Entities;

namespace Query.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        public BaseService() { }

        public Task<IEnumerable<T>> GetAllAsync(int count = -1, int skip = -1, string search = "")
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
