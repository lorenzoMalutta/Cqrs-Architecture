using System.ComponentModel.DataAnnotations;

namespace Command.Commands.Music.Requests
{
    public class DeleteMusicRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
