using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class CandidateCreateModelValidator
        : AbstractValidator<CandidateCreateModel>
    {
        public CandidateCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.Adt).MaximumLength(50);
            RuleFor(p => p.Afm).MaximumLength(9);
            RuleFor(p => p.Address).MaximumLength(50);
            RuleFor(p => p.StreetNumber).MaximumLength(10);
            RuleFor(p => p.City).MaximumLength(50);
            RuleFor(p => p.PostalCode).MaximumLength(5);
            RuleFor(p => p.Phone).MaximumLength(50);
            RuleFor(p => p.Email).MaximumLength(50);
            #endregion
        }

    }
}
