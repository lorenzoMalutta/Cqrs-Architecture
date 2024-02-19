﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Utils.Entities;

namespace Command.Entity
{
    public class Album : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public Guid ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual ICollection<Music> Music { get; set; }

        public virtual ICollection<Tracks> Tracks { get; set; }

        public Album() : base() { }
    }
}
