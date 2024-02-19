using System.ComponentModel.DataAnnotations;

namespace Command.Commands.Artist.Requests
{
    public class DeleteArtistRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
