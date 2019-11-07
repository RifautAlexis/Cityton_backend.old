using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Service.Validators
{
    class GroupValidator : AbstractValidator<Group>
    {

        public GroupValidator()
        {
            RuleFor(user => user.Name).MinimumLength(3);
            RuleFor(user => user.Picture).NotEmpty();
            RuleFor(user => user.CreatedAt).NotEmpty();
        }

    }
}
