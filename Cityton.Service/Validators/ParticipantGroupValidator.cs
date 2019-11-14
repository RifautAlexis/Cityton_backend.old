using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Service.Validators
{
    class ParticipantGroupValidator : AbstractValidator<ParticipantGroup>
    {

        public ParticipantGroupValidator()
        {
            RuleFor(participantGroup => participantGroup.IsCreator).NotNull();
            RuleFor(participantGroup => participantGroup.Status).NotNull().IsInEnum();
        }

    }
}
