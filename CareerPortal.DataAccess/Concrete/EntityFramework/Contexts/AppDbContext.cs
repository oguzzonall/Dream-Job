using CareerPortal.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<JobPostStatus> PostStatuses { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Sector> Sectors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
