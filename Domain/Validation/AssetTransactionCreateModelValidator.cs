using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AssetTransactionCreateModelValidator
        : AbstractValidator<AssetTransactionCreateModel>
    {
        public AssetTransactionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.InvoiceNo).MaximumLength(50);
            RuleFor(p => p.Employee).MaximumLength(250);
            #endregion
        }

    }
}
