using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class InfoMessageUpdateModelValidator
        : AbstractValidator<InfoMessageUpdateModel>
    {
        public InfoMessageUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Caption).NotEmpty();
            RuleFor(p => p.Caption).MaximumLength(50);
            RuleFor(p => p.Message).NotEmpty();
            RuleFor(p => p.LinkTable).MaximumLength(50);
            #endregion
        }

    }
}
