using Cityton.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cityton.Data.Common;

namespace Cityton.Service.Validators.ExtensionsMethod
{
    public static class UserValidator
    {

        public static IRuleBuilderOptions<T, int> IdValidation<T>(this IRuleBuilder<T, int> rule)
        {
            return rule
                .NotNull()
                .GreaterThan(0);
        }

        public static IRuleBuilderOptions<T, string> UsernameValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty()
                .MinimumLength(3)
                .NotStartEndWithWhiteSpace();
        }

        public static IRuleBuilderOptions<T, string> PhoneNumberValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .When(pn => !string.IsNullOrEmpty(pn))
                .NotEmpty()
                .MinimumLength(10)
                .NotStartEndWithWhiteSpace();
        }

        public static IRuleBuilderOptions<T, string> EmailValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty()
                .NotStartEndWithWhiteSpace()
                .EmailAddress();
        }

        public static IRuleBuilderOptions<T, string> PictureValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty()
                .NotStartEndWithWhiteSpace();
        }

        public static IRuleBuilderOptions<T, Role> RoleValidation<T>(this IRuleBuilder<T, Role> rule)
        {
            return rule
                .NotEmpty()
                .IsInEnum();
        }

        public static IRuleBuilderOptions<T, string> TokenValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty()
                .NotStartEndWithWhiteSpace();
        }

        /*
         * RegisterDTO & LoginDTO
         */
        public static IRuleBuilderOptions<T, string> PasswordValidation<T>(this IRuleBuilder<T, string> rule)
        {
            return rule
                .NotEmpty()
                .MinimumLength(3)
                .NotStartEndWithWhiteSpace();
        }

    }
}
