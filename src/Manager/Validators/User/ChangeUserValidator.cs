using FluentValidation;
using src.newDockeNet.Core.ChangeModelsView;

namespace src.newDockeNet.Manager.Validators.User
{
    public class ChangeUserValidator : AbstractValidator<ChangeUserModel>
    {
        public ChangeUserValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}