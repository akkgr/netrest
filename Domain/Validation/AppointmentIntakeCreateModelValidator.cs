using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AppointmentIntakeCreateModelValidator
        : AbstractValidator<AppointmentIntakeCreateModel>
    {
        public AppointmentIntakeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FullName).MaximumLength(250);
            #endregion
        }

    }
}
