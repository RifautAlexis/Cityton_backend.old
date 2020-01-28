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
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(3, 50).WithMessage("Have to contains between 3 to 50 characters !")
                .MustAsync(async (name, cancellation) => !(await groupService.ExistName(name)))
                .WithMessage("{PropertyValue} is already taken !");
            RuleFor(gba => gba.CreatorId)
                .GreaterThan(0).WithMessage("{PropertyName} is inferior or equalts to 0")
                .MustAsync(async (creatorId, cancellation) => !(await groupService.IsAccepted(creatorId)))
                .WithMessage("{PropertyValue} is already taken !");
            RuleFor(gba => gba.MembersId)
                .MustAsync(async (members, cancellation) => await groupService.IsConformSize(members.Count + 1))
                .WithMessage("La taille du groupe est trop petite ou trop gande");
            RuleForEach(gba => gba.MembersId)
                .GreaterThan(0).WithMessage("{PropertyName} is inferior or equalts to 0")
                .MustAsync(async (memberId, cancellation) => !(await groupService.IsAccepted(memberId)))
                .WithMessage("{PropertyValue} is already taken !");
        }

    }
}
