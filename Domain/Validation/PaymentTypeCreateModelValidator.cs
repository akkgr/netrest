using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class PaymentTypeCreateModelValidator
        : AbstractValidator<PaymentTypeCreateModel>
    {
        public PaymentTypeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(150);
            #endregion
        }

    }
}
