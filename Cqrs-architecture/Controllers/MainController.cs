using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using Utils.Response;

namespace Cqrs_architecture.Controllers
{
    [Authorize]
    [ApiController]
    public class MainController : ControllerBase
    {
        protected string? UserName => User.Identity?.Name;
        protected string? UserEmail => User?.FindFirstValue(ClaimTypes.Email);
        protected Guid UserId { get { return new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier)); } }

        public MainController() { }
        public override OkResult Ok() => throw new NotImplementedException();
        public override NoContentResult NoContent() => throw new NotImplementedException();
        public override BadRequestResult BadRequest() => throw new NotImplementedException();
        public override StatusCodeResult StatusCode([ActionResultStatusCode] int statusCode) => throw new NotImplementedException();
        public override UnauthorizedResult Unauthorized() => throw new NotImplementedException();

        [NonAction]
        public virtual ObjectResult HttpStatus200Ok(Response? value = null)
        {
            return base.StatusCode(StatusCodes.Status200OK, value);
        }

        [NonAction]
        public virtual StatusCodeResult HttpStatus204NoContent()
        {
            return base.StatusCode(StatusCodes.Status204NoContent);
        }

        [NonAction]
        public virtual ObjectResult HttpStatus400BadRequest(string message)
        {
            return base.StatusCode(StatusCodes.Status400BadRequest, new Response { Message = message });
        }
        [NonAction]
        public virtual StatusCodeResult HttpStatus403Unauthorized()
        {
            return base.StatusCode(StatusCodes.Status403Forbidden);
        }

        [NonAction]
        public virtual ObjectResult HttpStatus422UnprocessableEntity(string message, Dictionary<string, string[]> errors)
        {
            return base.StatusCode(StatusCodes.Status422UnprocessableEntity, new Response
            {
                Message = message,
                Errors = errors
            });
        }

        [NonAction]
        public virtual ObjectResult HttpStatus500InternalServerError(Response? value)
        {
            return base.StatusCode(StatusCodes.Status500InternalServerError, value);
        }
        [NonAction]
        public virtual ObjectResult HttpStatus500InternalServerError(string message)
        {
            var value = new Response { Message = message };
            return HttpStatus500InternalServerError(value);
        }

        [NonAction]
        public virtual ObjectResult ModelStateError(ModelStateDictionary modelState)
        {
            var modelStateErrors = modelState.Values.SelectMany(e => e.Errors);
            var errors = new List<string>();

            foreach (var error in modelStateErrors)
            {
                var errorMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                errors.Add(errorMsg);
            }

            return HttpStatus400BadRequest(string.Join(", ", errors));
        }
    }
}
