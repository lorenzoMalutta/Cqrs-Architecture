using System.ComponentModel.DataAnnotations;
using Utils.Entities;

namespace Command.Entity
{
    public class Tracks : BaseEntity
    {
        [Required]
        public Guid AlbumId { get; set; }

        [Required]
        public Guid MusicId { get; set; }

        [Required]
        public virtual Album Album { get; set; }

        [Required]
        public virtual ICollection<Music> Music { get; set; }

        public Tracks() : base() { }
    }
}
