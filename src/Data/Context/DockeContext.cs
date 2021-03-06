using Microsoft.EntityFrameworkCore;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Data.Configurations;

namespace src.newDockeNet.Data.Context
{
    public class DockeContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<DPOModel> DPOs { get; set; }
        public DbSet<CompanyModel> Companys { get; set; }

        public DockeContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserDbConfiguration());
            modelBuilder.ApplyConfiguration(new DPODbConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyDbConfiguration());
        }
    }
}