using System.ComponentModel.DataAnnotations;
using Utils.Entities;

namespace Command.Entity
{
    public class Artist : BaseEntity
    {   
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        [Required]
        public string SiteUrl { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual ICollection<Album>? Album { get; set; }

        public Artist() : base() { }
    }
}
