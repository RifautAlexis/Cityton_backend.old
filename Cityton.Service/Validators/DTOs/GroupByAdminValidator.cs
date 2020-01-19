using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class GroupByAdminValidator : AbstractValidator<GroupByAdmin>
    {

        public GroupByAdminValidator(IGroupService groupService)
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(gba => gba.Name)
                .NotEmpty()
                .Length(3, 50).WithMessage("Have to contains between 3 to 50 characters !")
                .MustAsync(async (name, cancellation) => !(await groupService.ExistName(name)));
            RuleFor(gba => gba.CreatorId).MustAsync(async (creatorId, cancellation) => !(await groupService.IsAccepted(creatorId)));
            RuleForEach(gba => gba.MembersId).MustAsync(async (creatorId, cancellation) => !(await groupService.IsAccepted(creatorId)));

        }

    }
}
