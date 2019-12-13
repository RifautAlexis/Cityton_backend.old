using Cityton.Data.Models;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(user => user.Username).UsernameValidation();
            RuleFor(user => user.PhoneNumber).PhoneNumberValidation();
            RuleFor(user => user.Email).EmailValidation();
            RuleFor(user => user.PasswordHash).NotEmpty();
            RuleFor(user => user.PasswordSalt).NotEmpty();
            RuleFor(user => user.Picture).PictureValidation();
            RuleFor(user => user.Role).RoleValidation();
            RuleFor(user => user.Token).TokenValidation();
        }

    }
}