using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AssetCreateModelValidator
        : AbstractValidator<AssetCreateModel>
    {
        public AssetCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.InvoiceNo).MaximumLength(50);
            RuleFor(p => p.AssetNo).MaximumLength(50);
            RuleFor(p => p.Description).MaximumLength(250);
            RuleFor(p => p.Barcode).MaximumLength(50);
            RuleFor(p => p.AssetCode).MaximumLength(50);
            RuleFor(p => p.Supplier).MaximumLength(250);
            RuleFor(p => p.EmployeeName).MaximumLength(250);
            #endregion
        }

    }
}
