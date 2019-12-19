using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Service.Validators
{
    public static class CustomValidators
    {

        public static IRuleBuilderOptions<T, string> NotStartEndWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.NotStartWithWhiteSpace().NotEndWithWhiteSpace();
            // return ruleBuilder.Must(x => x != null && !x.StartsWith(" ") && !x.EndsWith(" "));
        }

        public static IRuleBuilderOptions<T, string> NotStartWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(x => x != null && !x.StartsWith(" ")).WithMessage("'{PropertyName}' should not start with whitespace");
        }

        public static IRuleBuilderOptions<T, string> NotEndWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(x => x != null && !x.EndsWith(" ")).WithMessage("'{PropertyName}' should not end with whitespace");
        }

    }
}
