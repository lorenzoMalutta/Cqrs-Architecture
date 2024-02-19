using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Command.Commands.Music.Requests
{
    public class UpdateMusicRequest
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The max of character is 100")]
        public string Title { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }
    }
}
