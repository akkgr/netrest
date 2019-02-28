using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ReceiptUpdateModelValidator
        : AbstractValidator<ReceiptUpdateModel>
    {
        public ReceiptUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Publisher).MaximumLength(250);
            RuleFor(p => p.Trader).MaximumLength(250);
            RuleFor(p => p.TaxRecocrd).MaximumLength(9);
            #endregion
        }

    }
}
