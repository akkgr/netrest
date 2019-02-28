using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class DocumentUpdateModelValidator
        : AbstractValidator<DocumentUpdateModel>
    {
        public DocumentUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FromTo).MaximumLength(250);
            RuleFor(p => p.InDocRegistration).MaximumLength(30);
            RuleFor(p => p.Receipt).MaximumLength(30);
            RuleFor(p => p.TempRegistration).MaximumLength(30);
            RuleFor(p => p.Registration).MaximumLength(30);
            RuleFor(p => p.OutDocRegistration).MaximumLength(30);
            #endregion
        }

    }
}
