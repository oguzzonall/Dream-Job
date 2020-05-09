using CareerPortal.Core.Entities.Concrete;
using CareerPortal.DataAccess.Concrete.EntityFramework.Configurations;
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
        public DbSet<JobPostStatus> JobPostStatuses { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Sector> Sectors { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobPostConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new ExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new JobPostStatusConfiguration());
            modelBuilder.ApplyConfiguration(new JobTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new SectorConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new OperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserOperationClaimConfiguration());

            modelBuilder.Entity<JobPost>().HasOne(x => x.Region).WithMany().HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
