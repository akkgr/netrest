using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ClientHistoryUpdateModelValidator
        : AbstractValidator<ClientHistoryUpdateModel>
    {
        public ClientHistoryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Referral).MaximumLength(150);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MaximumLength(150);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(150);
            RuleFor(p => p.MotherName).MaximumLength(150);
            RuleFor(p => p.FatherName).MaximumLength(150);
            RuleFor(p => p.Amka).MaximumLength(11);
            RuleFor(p => p.Amy).MaximumLength(50);
            RuleFor(p => p.Afm).MaximumLength(9);
            RuleFor(p => p.IncomeRemarks).MaximumLength(250);
            RuleFor(p => p.Address).MaximumLength(250);
            RuleFor(p => p.Phone).MaximumLength(10);
            RuleFor(p => p.JobComment).MaximumLength(250);
            RuleFor(p => p.HealthComment).MaximumLength(250);
            RuleFor(p => p.ReferenceToComment).MaximumLength(250);
            RuleFor(p => p.BarCode).MaximumLength(50);
            RuleFor(p => p.RealEstate).MaximumLength(500);
            RuleFor(p => p.Loan).MaximumLength(500);
            RuleFor(p => p.IdCard).MaximumLength(50);
            RuleFor(p => p.StayPermit).MaximumLength(50);
            RuleFor(p => p.StayPermitDuration).MaximumLength(50);
            RuleFor(p => p.DependentsIncome).MaximumLength(50);
            RuleFor(p => p.Mobile).MaximumLength(50);
            #endregion
        }

    }
}
