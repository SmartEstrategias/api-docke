using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using newDockeNet.Core.Models;

namespace newDockeNet.Data.Configurations
{
    public class CompanyDbConfiguration : IEntityTypeConfiguration<CompanyModel>
    {
        public void Configure(EntityTypeBuilder<CompanyModel> builder)
        {
            // builder.HasOne(p => p.User)
            //         .WithOne(p => p.Company)
            //         .HasForeignKey<CompanyModel>(p => p.UserId);

            builder.HasKey(p => p.CompanyId);
        }
    }
}