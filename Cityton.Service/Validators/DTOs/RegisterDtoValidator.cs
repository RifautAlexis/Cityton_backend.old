using Cityton.Data.DTOs;
using FluentValidation;
using Cityton.Service.Validators.ExtensionsMethod;

namespace Cityton.Service.Validators.DTOs
{
    public class RegisterDTOValidator : AbstractValidator<RegisterDTO>
    {

        public RegisterDTOValidator()
        {

            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(user => user.Username)
                .UsernameValidation()
                .MustAsync(async (username, cancellation) => await UserService.IsUniqueUsername(username));
            RuleFor(user => user.PhoneNumber)
                .PhoneNumberValidation()
                .When(pn => pn != null).MustAsync(async (phonenumber, cancellation) => await UserService.IsUniquePhoneNumber(phonenumber));
            RuleFor(user => user.Email)
                .EmailValidation()
                .MustAsync(async (phonenumber, cancellation) => await UserService.IsUniqueEmail(phonenumber));
            RuleFor(user => user.Password).PasswordValidation();
        }

    }
}