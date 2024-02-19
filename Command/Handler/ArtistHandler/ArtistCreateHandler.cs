using Command.Commands.Artist.Requests;
using Command.Commands.Artist.Responses;
using Command.Common;
using Command.Entity;
using Command.Service.Interface;

namespace Command.Handler.ArtistHandler
{
    public class ArtistCreateHandler : ICommandHandler<CreateArtistRequest, CreateArtistResponse>
    {
        private readonly IArtistService _artistService;
        public ArtistCreateHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public Task<CreateArtistResponse> Handle(CreateArtistRequest command, CancellationToken cancellationToken, string? userName)
        {
            var entity = new Artist
            {
                Name = command.Name,
                Country = command.Country,
                SiteUrl = command.SiteUrl,
                ImageUrl = command.ImageUrl,
                DateUtcIn = DateTime.UtcNow,
                UserIn = "user"
            };

            _artistService.CreateAsync(entity, userName);

            return Task.FromResult(new CreateArtistResponse
            {
                Name = entity.Name,
                SiteUrl = entity.SiteUrl,
                ImageUrl = entity.ImageUrl
            });
        }
    }
}
