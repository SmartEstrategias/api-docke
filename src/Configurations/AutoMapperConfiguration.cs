using Microsoft.Extensions.DependencyInjection;
using src.newDockeNet.Manager.Mapping.Company;
using src.newDockeNet.Manager.Mapping.DPO;
using src.newDockeNet.Manager.Mapping.User;

namespace src.newDockeNet.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection Services)
        {
            Services.AddAutoMapper(
            typeof(NewUserMapping),
            typeof(ChangeUserMapping),
            typeof(NewDpoMapping),
            typeof(ChangeDpoMapping),
            typeof(NewCompanyMapping),
            typeof(ChangeCompanyMapping)
            );
        }
    }
}