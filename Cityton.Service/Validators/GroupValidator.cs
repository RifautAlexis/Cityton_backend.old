using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Service.Validators
{
    public class GroupValidator : AbstractValidator<Group>
    {

        public GroupValidator()
        {
            RuleFor(group => group.Name).NotEmpty().MinimumLength(3);
            RuleFor(group => group.Picture).NotEmpty();
            RuleFor(group => group.CreatedAt).NotNull();
        }

    }
}