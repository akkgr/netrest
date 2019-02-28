using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class UserLoginUpdateModelValidator
        : AbstractValidator<UserLoginUpdateModel>
    {
        public UserLoginUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LoginProvider).NotEmpty();
            RuleFor(p => p.LoginProvider).MaximumLength(100);
            RuleFor(p => p.ProviderKey).NotEmpty();
            RuleFor(p => p.ProviderKey).MaximumLength(100);
            #endregion
        }

    }
}
