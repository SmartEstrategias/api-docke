using newDockeNet.Manager.Mapping.Company;
using newDockeNet.Manager.Mapping.DPO;
using newDockeNet.Manager.Mapping.User;

namespace newDockeNet.Configurations
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