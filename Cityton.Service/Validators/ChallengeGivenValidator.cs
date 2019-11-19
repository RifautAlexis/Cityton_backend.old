using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Service.Validators
{
    public class ChallengeGivenValidator : AbstractValidator<ChallengeGiven>
    {

        public ChallengeGivenValidator()
        {
            RuleFor(challengeGiven => challengeGiven.Status).NotNull().IsInEnum();
        }

    }
}
