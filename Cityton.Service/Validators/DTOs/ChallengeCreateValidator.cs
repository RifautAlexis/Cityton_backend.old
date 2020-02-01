using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class ChallengeCreateValidator : AbstractValidator<ChallengeCreate>
    {

        public ChallengeCreateValidator(IChallengeService challengeService)
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(cc => cc.Name)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(3, 50).WithMessage("Have to contains between 3 to 50 characters !")
                .MustAsync(async (name, cancellation) => !(await challengeService.ExistName(name)))
                .WithMessage("{PropertyValue} is already taken !");
            RuleFor(cc => cc.Statement)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(10, 100).WithMessage("Have to contains between 10 to 100 characters !");
        }

    }
}
