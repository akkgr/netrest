using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AssetTransactionUpdateModelValidator
        : AbstractValidator<AssetTransactionUpdateModel>
    {
        public AssetTransactionUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.InvoiceNo).MaximumLength(50);
            RuleFor(p => p.Employee).MaximumLength(250);
            #endregion
        }

    }
}
