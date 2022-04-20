using Microsoft.EntityFrameworkCore;
using newDockeNet.Data.Context;

namespace newDockeNet.Configurations
{
    public static class DbConfiguration
    {
        public static void AddDatabaseConfiguration(this IServiceCollection Services, IConfiguration Configuration)
        {
            Services.AddDbContext<DockeContext>
            (options => options.UseSqlite(Configuration.GetConnectionString("Connection")));
        }

        public static void UseDatabaseConfiguration(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<DockeContext>();
            context.Database.Migrate();
            context.Database.EnsureCreated();
        }
    }
}