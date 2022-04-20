using FluentValidation;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Validators.User
{
    public class NewUserValidator : AbstractValidator<NewUserModel>
    {
        public NewUserValidator()
        {
            RuleFor(x => x.Email).NotNull().EmailAddress();
        }
    }
}