using Command.Commands.Music.Requests;
using Command.Commands.Music.Responses;
using Command.Common;
using Command.Entity;
using Command.Service.Interface;

namespace Command.Handler.MusicHandler
{
    public class MusicUpdateHandler : ICommandHandler<UpdateMusicRequest, UpdateMusicResponse>
    {
        private readonly IMusicService _musicService;

        public MusicUpdateHandler(IMusicService musicService)
        {
            _musicService = musicService;
        }

        public Task<UpdateMusicResponse> Handle(UpdateMusicRequest command, CancellationToken cancellationToken, string? userName)
        {
            var entity = new Music
            {
                Title = command.Title,
                Duration = command.Duration,
                DateUtcIn = DateTime.UtcNow,
                UserIn = "user"
            };

            _musicService.UpdateAsync(entity, userName);

            return Task.FromResult(new UpdateMusicResponse
            {
                Duration = entity.Duration,
                Title = entity.Title
            }); ;
        }
    }
}
