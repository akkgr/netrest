using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class EducationUpdateModelValidator
        : AbstractValidator<EducationUpdateModel>
    {
        public EducationUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(150);
            #endregion
        }

    }
}
