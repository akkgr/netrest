using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AppointmentTypeUpdateModelValidator
        : AbstractValidator<AppointmentTypeUpdateModel>
    {
        public AppointmentTypeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(250);
            RuleFor(p => p.Color).MaximumLength(10);
            #endregion
        }

    }
}
