using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Service.Validators
{
    public class GroupValidator : AbstractValidator<Group>
    {

        public GroupValidator(IGroupService groupService)
        {
            RuleFor(group => group.Name).NotEmpty()
                .Length(3, 50)
                .MustAsync(async (name, cancellation) => !(await groupService.ExistName(name)));
            RuleFor(group => group.CreatedAt).NotNull();
        }

    }
}