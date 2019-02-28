using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ModeratorCreateModelValidator
        : AbstractValidator<ModeratorCreateModel>
    {
        public ModeratorCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FullName).MaximumLength(250);
            #endregion
        }

    }
}
