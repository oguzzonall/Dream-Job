using CareerPortal.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Configurations
{
    public class JobPostConfiguration : IEntityTypeConfiguration<JobPost>
    {
        public void Configure(EntityTypeBuilder<JobPost> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.JobPostTitle).IsRequired().HasMaxLength(100);
            builder.Property(x => x.JobPostDescription).IsRequired();
            builder.Property(x => x.ReleaseDate).IsRequired();

            builder.Property(x => x.WebSiteUrl).HasMaxLength(50);
            builder.Property(x => x.FacebookUrl).HasMaxLength(50);
            builder.Property(x => x.TwitterUrl).HasMaxLength(50);
            builder.Property(x => x.LinkedinUrl).HasMaxLength(50);

            builder.Property(x => x.JobPostImageUrl).HasMaxLength(100);
            builder.Property(x => x.ComponyLogoUrl).HasMaxLength(100);
        }
    }
}
