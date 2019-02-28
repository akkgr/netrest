using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class CertificationCreateModelValidator
        : AbstractValidator<CertificationCreateModel>
    {
        public CertificationCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(200);
            #endregion
        }

    }
}
