using Utils.Entities;

namespace Query.Service.Interface
{
    public interface IBaseService<T> where T : BaseEntity
    {
        public Task<T> GetByIdAsync(Guid id);
        public Task<IEnumerable<T>> GetAllAsync(int count = -1, int skip = -1, string search = "");
    }
}
