using Command.Commands.Music.Requests;
using Command.Commands.Music.Responses;
using Command.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Query.Common;
using Utils.Response;

namespace Cqrs_architecture.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : MainController
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public MusicController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base()
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateMusic([FromBody] CreateMusicRequest command, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher.Dispatch<CreateMusicRequest, CreateMusicResponse>(command, cancellationToken, UserName);

            return HttpStatus200Ok(new Response { Message = "Music created successfully", Content = response, Status = "Ok" });
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteMusic([FromQuery] DeleteMusicRequest command, CancellationToken cancellationToken)
        {
            var response = await _commandDispatcher.Dispatch<DeleteMusicRequest, DeleteMusicResponse>(command, cancellationToken, UserName);

            return HttpStatus200Ok(new Response { Message = "Music deleted successfully", Content = response, Status = "Ok" });
        }

        [HttpPatch("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateMusic([FromRoute] Guid id, [FromBody] UpdateMusicRequest command, CancellationToken cancellationToken)
        {
            command.Id = id;
            var response = await _commandDispatcher.Dispatch<UpdateMusicRequest, UpdateMusicResponse>(command, cancellationToken, UserName);

            return HttpStatus200Ok(new Response { Message = "Music updated successfully", Content = response, Status = "Ok" });
        }
    }
}
