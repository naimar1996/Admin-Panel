using FrontToEnd1.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToEnd1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }
        public DbSet<CreateSuccess> CreateSuccess { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<FeaturedWork> FeaturedWorks { get; set; }

    }
}
