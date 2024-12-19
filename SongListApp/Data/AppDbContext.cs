using Microsoft.EntityFrameworkCore;
using SongListApp.Data;

namespace SongListApp.Data // Pazite da prostor imena odgovara vašem projektu
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Song> Songs { get; set; }
    }
}

