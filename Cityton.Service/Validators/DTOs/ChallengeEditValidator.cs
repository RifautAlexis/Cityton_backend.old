using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class ChallengeEditValidator : AbstractValidator<ChallengeEdit>
    {

        public ChallengeEditValidator(IChallengeService challengeService)
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(ce => ce.Id)
                .MustAsync(async (id, cancellation) => await challengeService.Get(id) != null)
                .WithMessage("{PropertyValue} doesn't exists !");
            RuleFor(ce => ce.Name)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(3, 50).WithMessage("Have to contains between 3 to 50 characters !")
                .MustAsync(async (name, cancellation) => !(await challengeService.ExistName(name)))
                .WithMessage("{PropertyValue} is already taken !");
            RuleFor(ce => ce.Statement)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(10, 100).WithMessage("Have to contains between 10 to 100 characters !");
        }

    }
}
