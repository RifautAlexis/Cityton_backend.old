using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;
using Cityton.Data.Common;
using FluentValidation;

namespace Cityton.Service.Validators
{
    public class UserInDiscussionValidator : AbstractValidator<UserInDiscussion>
    {

        public UserInDiscussionValidator()
        {
            RuleFor(userInDiscussion => userInDiscussion.JoinedAt).NotNull();
        }

    }
}