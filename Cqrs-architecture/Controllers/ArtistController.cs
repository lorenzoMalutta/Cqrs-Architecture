using Command.Commands.Artist.Requests;
using Command.Commands.Artist.Responses;
using Command.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Query.Common;
using Utils.Response;

namespace Cqrs_architecture.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : MainController
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public ArtistController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateArtist([FromBody] CreateArtistRequest command, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher.Dispatch<CreateArtistRequest, CreateArtistResponse>(command, cancellationToken, UserName);

            return HttpStatus200Ok(new Response { Message = "Artist created successfully", Content = response, Status = "Ok" });
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteArtist([FromQuery] DeleteArtistRequest command, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher.Dispatch<DeleteArtistRequest, DeleteArtistResponse>(command, cancellationToken, UserName);

            return HttpStatus200Ok(new Response { Message = response.Message, Content = response, Status = "Ok" });
        }

        [HttpPatch("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateArtist([FromRoute] Guid id, [FromBody] UpdateArtistRequest command, CancellationToken cancellationToken)
        {
            command.Id = id;
            var response = await _commandDispatcher.Dispatch<UpdateArtistRequest, UpdateArtistResponse>(command, cancellationToken, UserName);

            return HttpStatus200Ok(new Response { Message = "Artist update successfully", Content = response, Status = "Ok" });
        }
    }
}
