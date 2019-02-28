using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class IntakeUpdateModelValidator
        : AbstractValidator<IntakeUpdateModel>
    {
        public IntakeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FirstName).MaximumLength(150);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(150);
            RuleFor(p => p.FatherName).MaximumLength(250);
            RuleFor(p => p.MotherName).MaximumLength(250);
            RuleFor(p => p.Job).MaximumLength(250);
            RuleFor(p => p.Insurance).MaximumLength(250);
            RuleFor(p => p.Afm).MaximumLength(50);
            RuleFor(p => p.Adt).MaximumLength(50);
            RuleFor(p => p.Amka).MaximumLength(50);
            RuleFor(p => p.Phone).MaximumLength(50);
            RuleFor(p => p.Mobile).MaximumLength(50);
            RuleFor(p => p.Address).MaximumLength(250);
            RuleFor(p => p.Resident).MaximumLength(50);
            RuleFor(p => p.Registered).MaximumLength(50);
            RuleFor(p => p.Request).NotEmpty();
            RuleFor(p => p.Reference).MaximumLength(250);
            RuleFor(p => p.BarCode).MaximumLength(50);
            RuleFor(p => p.School).MaximumLength(150);
            RuleFor(p => p.Email).MaximumLength(50);
            RuleFor(p => p.Languages).MaximumLength(500);
            RuleFor(p => p.OtherInfo).MaximumLength(500);
            #endregion
        }

    }
}
