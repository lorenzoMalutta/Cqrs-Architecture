using Command.Commands.Artist.Requests;
using Command.Commands.Artist.Responses;
using Command.Common;
using Command.Entity;
using Command.Service.Interface;

namespace Command.Handler.ArtistHandler
{
    public class ArtistUpdateHandler : ICommandHandler<UpdateArtistRequest, UpdateArtistResponse>
    {
        private readonly IArtistService _artistService;
        public ArtistUpdateHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }
        public Task<UpdateArtistResponse> Handle(UpdateArtistRequest command, CancellationToken cancellationToken, string? userName)
        {
            var entity = new Artist
            {
                Id = command.Id,
                Name = command.Name,
                Country = command.Country,
                SiteUrl = command.SiteUrl,
                ImageUrl = command.ImageUrl,
                DateUtcIn = DateTime.UtcNow,
                DateUtcUpd = DateTime.UtcNow,
                UserIn = "user"
            };

            _artistService.UpdateAsync(entity, userName);

            return Task.FromResult(new UpdateArtistResponse
            {
                Name = entity.Name,
                SiteUrl = entity.SiteUrl,
                ImageUrl = entity.ImageUrl
            });
        }
    }
}
