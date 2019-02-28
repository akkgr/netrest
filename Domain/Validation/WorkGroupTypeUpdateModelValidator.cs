using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class WorkGroupTypeUpdateModelValidator
        : AbstractValidator<WorkGroupTypeUpdateModel>
    {
        public WorkGroupTypeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(50);
            #endregion
        }

    }
}
