using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.DTOs;
using Cityton.Data.Models;
using FluentValidation;

namespace Cityton.Service.Validators.DTOs
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDTO>
    {

        private IUserService _userService;

        public RegisterDtoValidator(IUserService userService)
        {
            _userService = userService;

            RuleFor(user => user.Username).NotEmpty().MinimumLength(3);
            RuleFor(user => user.Username).Must(username => UniqueUsername(username)).WithMessage("Username déjà pésent !");
            RuleFor(user => user.PhoneNumber).NotEmpty().MinimumLength(10);
            RuleFor(user => user.PhoneNumber).Must(phoneNumber => UniqueEmail(phoneNumber)).WithMessage("Phone number déjà pésent !");
            RuleFor(user => user.Email).NotEmpty().EmailAddress();
            RuleFor(user => user.Email).Must(email => UniquePhoneNumber(email)).WithMessage("Email déjà pésent !");
            RuleFor(user => user.Password).NotEmpty();
        }

        private bool UniqueUsername(string username)
        {
            return _userService.GetByUsername(username) == null;
        }

        private bool UniqueEmail(string email)
        {
            return _userService.GetByEmail(email) == null;
        }

        private bool UniquePhoneNumber(string phoneNumber)
        {
            return _userService.GetByPhoneNumber(phoneNumber) == null;
        }
    }
}