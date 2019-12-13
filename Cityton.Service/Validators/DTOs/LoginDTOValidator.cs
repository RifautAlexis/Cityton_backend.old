using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class LoginDTOValidator : AbstractValidator<LoginDTO>
    {

        public LoginDTOValidator()
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(user => user.Email).EmailValidation();
            RuleFor(user => user.Password).PasswordValidation();
        }

    }
}
