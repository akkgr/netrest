using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class WorkGroupUpdateModelValidator
        : AbstractValidator<WorkGroupUpdateModel>
    {
        public WorkGroupUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            #endregion
        }

    }
}
