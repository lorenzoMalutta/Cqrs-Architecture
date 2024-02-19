using System.ComponentModel.DataAnnotations;

namespace Command.Commands.Music.Requests
{
    public class CreateMusicRequest
    {
        [Required]
        [MaxLength(100, ErrorMessage = "The max of character is 100")]
        public string Title { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }
    }
}
