using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cityton.Data.Common;

namespace Cityton.Service.Validators
{
    public class ParticipantGroupValidator : AbstractValidator<ParticipantGroup>
    {

        private IGroupService groupService;

        public ParticipantGroupValidator(IGroupService groupService)
        {
            this.groupService = groupService;

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(participantGroup => participantGroup.IsCreator).NotNull();
            RuleFor(participantGroup => participantGroup.Status).NotNull().IsInEnum();
            RuleFor(participantGroup => participantGroup.User).Must(user => user.Role == Role.Member).WithMessage("Must be a Member !");
            RuleFor(participantGroup => participantGroup.User)
                .MustAsync(async (data, cancellation) => !(await IsInAGroup(data)))
                .WithMessage("Is already in a group !");
            RuleFor(participantGroup => participantGroup)
                .Must(IdenticalGroupId)
                .Must(IdenticalUserId)
                .MustAsync(async (data, cancellation) => !(await ExistRequest(data)));

        }

        private bool IdenticalGroupId(ParticipantGroup data)
        {
            return data.BelongingGroupId == data.BelongingGroup.Id;
        }

        private bool IdenticalUserId(ParticipantGroup data)
        {
            return data.UserId == data.User.Id;
        }

        private async Task<bool> ExistRequest(ParticipantGroup data)
        {
            return await this.groupService.ExistRequest(data);
        }

        private async Task<bool> IsInAGroup(User data)
        {
            return await this.groupService.IsAccepted(data.Id);
        }

    }
}