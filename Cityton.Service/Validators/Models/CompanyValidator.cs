
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Service.Validators
{
    public class CompanyValidator : AbstractValidator<Company>
    {

        public CompanyValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(company => company.MinGroupSize).GreaterThanOrEqualTo(1).LessThanOrEqualTo(company => company.MaxGroupSize);
            RuleFor(company => company.MaxGroupSize).GreaterThanOrEqualTo(company => company.MinGroupSize);
            RuleFor(company => company.CreatedAt).NotNull();
        }

    }
}