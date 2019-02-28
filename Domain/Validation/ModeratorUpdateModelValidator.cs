using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ModeratorUpdateModelValidator
        : AbstractValidator<ModeratorUpdateModel>
    {
        public ModeratorUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FullName).MaximumLength(250);
            #endregion
        }

    }
}
