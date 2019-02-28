using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AppointmentIntakeUpdateModelValidator
        : AbstractValidator<AppointmentIntakeUpdateModel>
    {
        public AppointmentIntakeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FullName).MaximumLength(250);
            #endregion
        }

    }
}
