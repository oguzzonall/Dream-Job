using CareerPortal.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CareerPortal.DataAccess.Concrete.EntityFramework.Configurations
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
