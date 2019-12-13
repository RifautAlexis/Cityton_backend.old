using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class UserUpdateDTOValidator : AbstractValidator<UserUpdateDTO>
    {

        public UserUpdateDTOValidator()
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(user => user.Id).IdValidation();
            RuleFor(user => user.Username).UsernameValidation();
            RuleFor(user => user.PhoneNumber).PhoneNumberValidation();
            RuleFor(user => user.Email).EmailValidation();
            RuleFor(user => user.Picture).PictureValidation();
            RuleFor(user => user.Role).RoleValidation();
            RuleFor(user => user.Password).PasswordValidation();
        }

    }
}
