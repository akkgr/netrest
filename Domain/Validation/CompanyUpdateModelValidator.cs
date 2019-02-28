using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class CompanyUpdateModelValidator
        : AbstractValidator<CompanyUpdateModel>
    {
        public CompanyUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(250);
            RuleFor(p => p.Afm).MaximumLength(9);
            RuleFor(p => p.Address).MaximumLength(250);
            RuleFor(p => p.Area).MaximumLength(250);
            RuleFor(p => p.PostalCode).MaximumLength(5);
            RuleFor(p => p.Phone).MaximumLength(10);
            RuleFor(p => p.Fax).MaximumLength(10);
            RuleFor(p => p.Email).MaximumLength(50);
            #endregion
        }

    }
}
