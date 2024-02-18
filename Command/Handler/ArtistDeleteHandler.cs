using Command.Commands.Artist.Requests;
using Command.Commands.Artist.Responses;
using Command.Common;
using Command.Entity;
using Command.Service.Interface;

namespace Command.Handler
{
    public class ArtistDeleteHandler : ICommandHandler<DeleteArtistRequest, DeleteArtistResponse>
    {
        private readonly IArtistService _artistService;
        public ArtistDeleteHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public Task<DeleteArtistResponse> Handle(DeleteArtistRequest command, CancellationToken cancellationToken, string? userName)
        {
            var entity = new Artist
            {
                Id = command.Id
            };

            _artistService.DeleteAsync(entity);

            return Task.FromResult(new DeleteArtistResponse
            {
                Message = "Ok"
            });
        }
    }
}
