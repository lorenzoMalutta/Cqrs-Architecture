using Command.Commands.Music.Requests;
using Command.Commands.Music.Responses;
using Command.Common;
using Command.Entity;
using Command.Service.Interface;

namespace Command.Handler.MusicHandler
{
    public class MusicDeleteHandler : ICommandHandler<DeleteMusicRequest, DeleteMusicResponse>
    {
        private readonly IMusicService _musicService;
        public MusicDeleteHandler(IMusicService musicService)
        {
            _musicService = musicService;
        }
        public Task<DeleteMusicResponse> Handle(DeleteMusicRequest command, CancellationToken cancellationToken, string? userName)
        {
            var entity = new Music
            {
                Id = command.Id
            };

            _musicService.DeleteAsync(entity);

            return Task.FromResult(new DeleteMusicResponse
            {
                Message = "Music deleted"
            });
        }
    }
}
