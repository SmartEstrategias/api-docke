using newDockeNet.Data.Repository;
using newDockeNet.Manager.Implementations;
using newDockeNet.Manager.Interfaces;
using newDockeNet.Manager.Managment;

namespace newDockeNet.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection Services)
        {
            Services.AddScoped<IUserRepository, UserRepository>();
            Services.AddScoped<IDpoRepository, DPORepository>();
            Services.AddScoped<ICompanyRepository, CompanyRepository>();

            Services.AddScoped<IUserManager, UserManager>();
            Services.AddScoped<IDPOManager, DPOManager>();
            Services.AddScoped<ICompanyManager, CompanyManager>();
        }
    }
}