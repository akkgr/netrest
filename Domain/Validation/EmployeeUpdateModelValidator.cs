using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class EmployeeUpdateModelValidator
        : AbstractValidator<EmployeeUpdateModel>
    {
        public EmployeeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.FatherLastName).MaximumLength(50);
            RuleFor(p => p.FatherFirstName).MaximumLength(50);
            RuleFor(p => p.MotherLastName).MaximumLength(50);
            RuleFor(p => p.MotherFirstName).MaximumLength(50);
            RuleFor(p => p.PlaceOfBirth).MaximumLength(250);
            RuleFor(p => p.Afm).MaximumLength(9);
            RuleFor(p => p.EducationRemarks).MaximumLength(500);
            RuleFor(p => p.Address).MaximumLength(50);
            RuleFor(p => p.City).MaximumLength(50);
            RuleFor(p => p.PostCode).MaximumLength(50);
            RuleFor(p => p.HomePhone).MaximumLength(50);
            RuleFor(p => p.MobilePhone).MaximumLength(50);
            RuleFor(p => p.Email).MaximumLength(50);
            RuleFor(p => p.IdCard).MaximumLength(50);
            RuleFor(p => p.AlienCard).MaximumLength(50);
            RuleFor(p => p.AlienPass).MaximumLength(50);
            RuleFor(p => p.Contract).MaximumLength(50);
            RuleFor(p => p.InsuranceNumber).MaximumLength(50);
            RuleFor(p => p.Amka).MaximumLength(50);
            RuleFor(p => p.Salary).MaximumLength(50);
            RuleFor(p => p.SalaryExtra).MaximumLength(50);
            RuleFor(p => p.Kad).MaximumLength(50);
            RuleFor(p => p.SpecialtyCode).MaximumLength(50);
            RuleFor(p => p.InsurancePack).MaximumLength(50);
            RuleFor(p => p.SpecialInsurance).MaximumLength(50);
            RuleFor(p => p.BarCode).MaximumLength(50);
            RuleFor(p => p.Bank).MaximumLength(250);
            RuleFor(p => p.BankAccount).MaximumLength(250);
            #endregion
        }

    }
}
