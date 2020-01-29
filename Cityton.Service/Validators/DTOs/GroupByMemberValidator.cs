using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class GroupByMemberValidator : AbstractValidator<GroupByMember>
    {

        public GroupByMemberValidator(IGroupService groupService)
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(gba => gba.Name)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(3, 50).WithMessage("Have to contains between 3 to 50 characters !")
                .MustAsync(async (name, cancellation) => !(await groupService.ExistName(name)))
                .WithMessage("{PropertyValue} is already in a group !");
            RuleFor(gba => gba.CreatorId)
                .GreaterThan(0).WithMessage("{PropertyName} is inferior or equalts to 0")
                .MustAsync(async (creatorId, cancellation) => !(await groupService.IsAccepted(creatorId)))
                .WithMessage("{PropertyValue} is already in a group !");
        }

    }
}
