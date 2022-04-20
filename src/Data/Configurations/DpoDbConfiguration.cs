using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Data.Configurations
{
    public class DPODbConfiguration : IEntityTypeConfiguration<DPOModel>
    {
        public void Configure(EntityTypeBuilder<DPOModel> builder)
        {
            // builder.HasOne(p => p.User)
            //         .WithOne(p => p.DPO)
            //         .HasForeignKey<DPOModel>(p => p.UserId);

            builder.HasKey(p => p.DpoId);
        }
    }
}