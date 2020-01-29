using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class GroupEditValidator : AbstractValidator<GroupEdit>
    {

        public GroupEditValidator(IGroupService groupService)
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(gie => gie.Id)
                .MustAsync(async (id, cancellation) => await groupService.Get(id) != null)
                .WithMessage("{PropertyValue} don't exists !");
            RuleFor(gie => gie.Name)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(3, 50).WithMessage("Have to contains between 3 to 50 characters !");
            RuleFor(gie => gie.CreatorId)
                .GreaterThan(0).WithMessage("{PropertyName} is inferior or equalts to 0 => {PropertyValue}");
            RuleForEach(gie => gie.MembersId)
                .GreaterThan(0).WithMessage("{PropertyName} is inferior or equalts to 0");
            RuleFor(gie => gie)
                .MustAsync(async (gie, cancellation) => !(await groupService.ExistNameEdit(gie.Id, gie.Name)))
                .WithMessage("{PropertyValue} is already in a group !")
                .MustAsync(async (gie, cancellation) => !(await groupService.IsAcceptedEdit(gie.Id, gie.CreatorId)))
                .WithMessage("{PropertyValue} is already in a group !")
                .MustAsync(async (gie, cancellation) => !(await groupService.IsAcceptedEdit(gie.Id, gie.MembersId)))
                .WithMessage("{PropertyValue} is already in a group !");
        }

    }
}
