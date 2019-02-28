using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class UserConnectionCreateModelValidator
        : AbstractValidator<UserConnectionCreateModel>
    {
        public UserConnectionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.UserName).MaximumLength(50);
            RuleFor(p => p.FullName).MaximumLength(150);
            RuleFor(p => p.ConnectionId).MaximumLength(50);
            #endregion
        }

    }
}
