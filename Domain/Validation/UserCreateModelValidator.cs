using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class UserCreateModelValidator
        : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FullName).NotEmpty();
            RuleFor(p => p.FullName).MaximumLength(150);
            RuleFor(p => p.UserName).NotEmpty();
            RuleFor(p => p.UserName).MaximumLength(50);
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MaximumLength(50);
            RuleFor(p => p.BarCode).MaximumLength(50);
            RuleFor(p => p.PasswordHash).MaximumLength(100);
            RuleFor(p => p.SecurityStamp).MaximumLength(100);
            RuleFor(p => p.Email).MaximumLength(100);
            RuleFor(p => p.NormalizedUserName).MaximumLength(50);
            RuleFor(p => p.ConcurrencyStamp).MaximumLength(50);
            RuleFor(p => p.NormalizedEmail).MaximumLength(100);
            #endregion
        }

    }
}
