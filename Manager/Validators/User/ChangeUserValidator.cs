using FluentValidation;
using newDockeNet.Core.ChangeModelsView;

namespace newDockeNet.Manager.Validators.User
{
    public class ChangeUserValidator : AbstractValidator<ChangeUserModel>
    {
        public ChangeUserValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}