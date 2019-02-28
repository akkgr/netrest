using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class PatientUpdateModelValidator
        : AbstractValidator<PatientUpdateModel>
    {
        public PatientUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Doctor).MaximumLength(250);
            RuleFor(p => p.DoctorName).MaximumLength(250);
            RuleFor(p => p.DoctorAMKA).MaximumLength(11);
            RuleFor(p => p.SatisfactionMeasurement).MaximumLength(50);
            RuleFor(p => p.SatisfactionDegree).MaximumLength(50);
            RuleFor(p => p.TerminationReason).MaximumLength(50);
            #endregion
        }

    }
}
