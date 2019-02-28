using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AppointmentUpdateModelValidator
        : AbstractValidator<AppointmentUpdateModel>
    {
        public AppointmentUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Subject).MaximumLength(250);
            #endregion
        }

    }
}
