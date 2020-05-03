using CareerPortal.Entities.Concrete;
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
        }
    }
}
