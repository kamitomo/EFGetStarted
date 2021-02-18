using EFGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("Host=localhost;Database=EFGetStarted;Username=postgres;Password=postgres");
    }
}
