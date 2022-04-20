using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using newDockeNet.Core.Models;

namespace newDockeNet.Data.Configurations
{
    public class UserDbConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(p => p.UserId);
        }
    }
}