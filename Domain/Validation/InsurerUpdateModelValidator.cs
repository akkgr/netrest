using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class InsurerUpdateModelValidator
        : AbstractValidator<InsurerUpdateModel>
    {
        public InsurerUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(150);
            #endregion
        }

    }
}
