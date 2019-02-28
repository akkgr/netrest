using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class FileLinkUpdateModelValidator
        : AbstractValidator<FileLinkUpdateModel>
    {
        public FileLinkUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.EntityType).NotEmpty();
            RuleFor(p => p.EntityType).MaximumLength(50);
            RuleFor(p => p.FileName).NotEmpty();
            RuleFor(p => p.FileName).MaximumLength(250);
            #endregion
        }

    }
}
