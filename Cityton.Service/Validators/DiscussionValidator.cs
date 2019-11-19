using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Service.Validators
{
    public class DiscussionValidator : AbstractValidator<Discussion>
    {

        public DiscussionValidator()
        {
            RuleFor(group => group.CreatedAt).NotNull();
        }

    }
}
