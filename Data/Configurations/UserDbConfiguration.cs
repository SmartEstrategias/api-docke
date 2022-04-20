using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using newDockeNet.Core.Models;

namespace newDockeNet.Data.Configurations
{
    public class UserDbConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            // builder.HasOne(p => p.DPO)
            //         .WithOne(p => p.User)
            //         .HasForeignKey<UserModel>(p => p.DPOId);

            // builder.HasOne(p => p.Company)
            //         .WithOne(p => p.User)
            //         .HasForeignKey<UserModel>(p => p.CompanyId);
        }
    }
}