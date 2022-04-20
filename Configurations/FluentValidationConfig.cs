using FluentValidation.AspNetCore;
using newDockeNet.Manager.Validators.User;

namespace newDockeNet.Configurations
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfig(this IServiceCollection Services)
        {
            Services.AddControllers()
                .AddFluentValidation(v => v.RegisterValidatorsFromAssemblyContaining<NewUserValidator>())
                .AddFluentValidation(v => v.RegisterValidatorsFromAssemblyContaining<ChangeUserValidator>());
        }
    }
}