using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ArchiveUpdateModelValidator
        : AbstractValidator<ArchiveUpdateModel>
    {
        public ArchiveUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(250);
            #endregion
        }

    }
}
