using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Data.Configurations
{
    public class UserDbConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(p => p.UserId);
        }
    }
}