using System.ComponentModel.DataAnnotations;

namespace Command.Commands.Artist.Requests
{
    public class CreateArtistRequest
    {
        [Required]
        [StringLength(100, ErrorMessage = "The name of the artist is max 100 character and min 1", MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The country of the artist is max 100 character and min 1", MinimumLength = 1)]
        public string Country { get; set; }

        [Required]
        [RegularExpression(@"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$", ErrorMessage = "Please enter a valid URL.")]
        public string SiteUrl { get; set; }

        [Required]
        [RegularExpression(@"^.*\.(jpg|jpeg|png|gif|bmp|tiff|svg\+xml)$", ErrorMessage = "Please enter a valid URL.")]
        public string ImageUrl { get; set; }
    }
}
