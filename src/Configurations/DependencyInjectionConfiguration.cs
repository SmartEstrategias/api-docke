using Microsoft.Extensions.DependencyInjection;
using src.newDockeNet.Data.Repository;
using src.newDockeNet.Manager.Implementations;
using src.newDockeNet.Manager.Interfaces;
using src.newDockeNet.Manager.Managment;

namespace src.newDockeNet.Configurations
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