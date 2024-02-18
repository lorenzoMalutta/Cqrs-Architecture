using Command.Entity;
using Microsoft.EntityFrameworkCore;
using Utils.EntityFramework;

namespace Command.Repository
{
    public class CommandDbContext : BaseDbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Tracks> Tracks { get; set; }

        public CommandDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasMany(a => a.Album)
                .WithOne(a => a.Artist)
                .HasForeignKey(a => a.ArtistId);

            modelBuilder.Entity<Album>()
                .HasMany(a => a.Music)
                .WithOne(m => m.Album)
                .HasForeignKey(m => m.AlbumId);

            modelBuilder.Entity<Tracks>()
                .HasOne(t => t.Album)
                .WithMany(a => a.Tracks)
                .HasForeignKey(t => t.AlbumId);

            modelBuilder.Entity<Tracks>()
                .HasMany(t => t.Music)
                .WithOne(m => m.Tracks)
                .HasForeignKey(m => m.TracksId);
        }
    }
}
