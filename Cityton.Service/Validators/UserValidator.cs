using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;
using Cityton.Data.Common;
using FluentValidation;

namespace Cityton.Service.Validators
{
    class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(user => user.Username).MinimumLength(3);
            RuleFor(user => user.PhoneNumber).MinimumLength (10);
            RuleFor(user => user.Email).EmailAddress();
            RuleFor(user => user.PasswordHash).NotEmpty();
            RuleFor(user => user.PasswordSalt).NotEmpty();
            RuleFor(user => user.Picture).NotEmpty();
            RuleFor(user => user.Role).NotEmpty().IsInEnum();
        }

    }
}