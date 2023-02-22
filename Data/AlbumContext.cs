using AlbumApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumApi.Data {
    public class AlbumContext : DbContext {
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options) {
            
        }

        public DbSet<Song> Song {get; set;}
        public DbSet<Album> Album {get; set;}
    }
}