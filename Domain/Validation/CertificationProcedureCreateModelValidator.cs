using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class CertificationProcedureCreateModelValidator
        : AbstractValidator<CertificationProcedureCreateModel>
    {
        public CertificationProcedureCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(100);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(10);
            #endregion
        }

    }
}
