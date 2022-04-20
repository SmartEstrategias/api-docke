using FluentValidation;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Validators.User
{
    public class NewUserValidator : AbstractValidator<NewUserModel>
    {
        public NewUserValidator()
        {
            // RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.Name).NotNull().MinimumLength(3);
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.EmailSecondary).EmailAddress();
            RuleFor(x => x.CPF).Length(11);
            RuleFor(x => x.Telephone).Length(10);
            RuleFor(x => x.Cellphone).Length(11);
        }
    }
}