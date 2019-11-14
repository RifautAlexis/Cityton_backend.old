using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Service.Validators
{
    class AchievementValidator : AbstractValidator<Achievement>
    {

        public AchievementValidator()
        {
            RuleFor(achievement => achievement.UnlockedAt).NotNull();
        }

    }
}
