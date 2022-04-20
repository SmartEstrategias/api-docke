using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using src.newDockeNet.Manager.Validators.User;

namespace src.newDockeNet.Configurations
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