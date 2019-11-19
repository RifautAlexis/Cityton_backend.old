using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Service.Validators
{
    public class AchievementValidator : AbstractValidator<Achievement>
    {

        public AchievementValidator()
        {
            RuleFor(achievement => achievement.UnlockedAt).NotNull();
        }

    }
}
