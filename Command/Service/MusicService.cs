using Command.Entity;
using Command.Repository;
using Command.Service.Interface;

namespace Command.Service
{
    public class MusicService : BaseService<Music>, IMusicService
    {
        public MusicService(ICommandRepository<Music> repository) : base(repository) { }
    }
}
