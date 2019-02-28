using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ActivityCodeUpdateModelValidator
        : AbstractValidator<ActivityCodeUpdateModel>
    {
        public ActivityCodeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(10);
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(500);
            #endregion
        }

    }
}
