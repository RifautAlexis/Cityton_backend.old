using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Service.Validators
{
    class ChallengeValidator : AbstractValidator<Challenge>
    {

        public ChallengeValidator()
        {
            RuleFor(challenge => challenge.Statement).NotEmpty().MinimumLength(10);
            RuleFor(challenge => challenge.Name).NotEmpty().MinimumLength(3);
            RuleFor(challenge => challenge.Status).NotNull().IsInEnum();
            RuleFor(challenge => challenge.CreatedAt).NotNull();
        }

    }
}
