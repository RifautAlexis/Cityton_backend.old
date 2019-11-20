using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.DTOs;
using FluentValidation;

namespace Cityton.Service.Validators.DTOs
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDTO>
    {

        public RegisterDtoValidator()
        {
            RuleFor(user => user.Username).NotEmpty().MinimumLength(3);
            RuleFor(user => user.PhoneNumber).NotEmpty().MinimumLength(10);
            RuleFor(user => user.Email).NotEmpty().EmailAddress();
            RuleFor(user => user.Password).NotEmpty();
        }

    }
}
