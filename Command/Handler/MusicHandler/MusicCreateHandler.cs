using Command.Commands.Music.Requests;
using Command.Commands.Music.Responses;
using Command.Common;
using Command.Entity;
using Command.Service.Interface;

namespace Command.Handler.MusicHandler
{
    public class MusicCreateHandler : ICommandHandler<CreateMusicRequest, CreateMusicResponse>
    {
        private readonly IMusicService _musicService;

        public MusicCreateHandler(IMusicService musicService)
        {
            _musicService = musicService;
        }

        public Task<CreateMusicResponse> Handle(CreateMusicRequest command, CancellationToken cancellationToken, string? userName)
        {
            var entity = new Music
            {
                Title = command.Title,
                Duration = command.Duration,
                DateUtcIn = DateTime.UtcNow,
                UserIn = "user"
            };

            _musicService.CreateAsync(entity, userName);

            return Task.FromResult(new CreateMusicResponse
            {
                Duration = entity.Duration,
                Title = entity.Title
            }); ;
        }
    }
}
