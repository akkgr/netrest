using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AppointmentCreateModelValidator
        : AbstractValidator<AppointmentCreateModel>
    {
        public AppointmentCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Subject).MaximumLength(250);
            #endregion
        }

    }
}
