using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ApplicantCreateModelValidator
        : AbstractValidator<ApplicantCreateModel>
    {
        public ApplicantCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ApplicationNumber).MaximumLength(50);
            RuleFor(p => p.ApplicationCode).MaximumLength(50);
            RuleFor(p => p.Publication).MaximumLength(50);
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FatherName).MaximumLength(50);
            RuleFor(p => p.MotherName).MaximumLength(50);
            RuleFor(p => p.Adt).MaximumLength(50);
            RuleFor(p => p.Amka).MaximumLength(50);
            RuleFor(p => p.Afm).MaximumLength(9);
            RuleFor(p => p.City).MaximumLength(50);
            RuleFor(p => p.Address).MaximumLength(50);
            RuleFor(p => p.StreetNumber).MaximumLength(10);
            RuleFor(p => p.PostalCode).MaximumLength(5);
            RuleFor(p => p.Phone).MaximumLength(50);
            RuleFor(p => p.Mobile).MaximumLength(50);
            RuleFor(p => p.Email).MaximumLength(50);
            RuleFor(p => p.Result).MaximumLength(50);
            #endregion
        }

    }
}
