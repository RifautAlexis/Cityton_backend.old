using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;
using Cityton.Data.Common;

namespace Cityton.Service.Validators
{
    class MediaValidator : AbstractValidator<Media>
    {

        public MediaValidator()
        {
            RuleFor(media => media.Name).NotEmpty().MinimumLength(3);
            RuleFor(media => media.Location).NotEmpty();
            RuleFor(media => media.Extension).NotNull().IsInEnum();
            RuleFor(media => media.CreatedAt).NotNull();
        }

    }
}
