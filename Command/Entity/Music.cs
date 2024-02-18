using System.ComponentModel.DataAnnotations;
using Utils.Entities;

namespace Command.Entity
{
    public class Music : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public Guid TracksId { get; set; }
        
        [Required]
        public Guid AlbumId { get; set; }

        public virtual Album Album { get; set; }

        public virtual Tracks Tracks { get; set; }

        public Music() : base() { }
    }
}
