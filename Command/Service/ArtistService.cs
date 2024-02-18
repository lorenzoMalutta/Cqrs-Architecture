using Command.Entity;
using Command.Repository;
using Command.Service.Interface;

namespace Command.Service
{
    public class ArtistService : BaseService<Artist>, IArtistService
    {
        public ArtistService(ICommandRepository<Artist> repository) : base(repository)
        {
        }
    }
}
