using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Service.Validators
{
    public class MessageValidator : AbstractValidator<Message>
    {

        public MessageValidator()
        {
            RuleFor(message => message.Content).NotEmpty().MinimumLength(1);
            RuleFor(message => message.CreatedAt).NotNull();
        }

    }
}