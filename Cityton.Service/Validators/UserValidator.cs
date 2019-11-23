using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;
using Cityton.Data.Common;
using FluentValidation;

namespace Cityton.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(user => user.Username).NotEmpty().MinimumLength(3);
            RuleFor(user => user.PhoneNumber).NotEmpty().MinimumLength(10);
            RuleFor(user => user.Email).NotEmpty().EmailAddress();
            RuleFor(user => user.PasswordHash).NotEmpty();
            RuleFor(user => user.PasswordSalt).NotEmpty();
            RuleFor(user => user.Picture).NotEmpty();
            RuleFor(user => user.Role).NotNull().IsInEnum();
            RuleFor(user => user.Token).NotEmpty();
        }

    }
}