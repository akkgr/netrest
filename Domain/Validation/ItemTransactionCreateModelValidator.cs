using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ItemTransactionCreateModelValidator
        : AbstractValidator<ItemTransactionCreateModel>
    {
        public ItemTransactionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(150);
            RuleFor(p => p.TransactionCause).MaximumLength(250);
            RuleFor(p => p.BarCode).NotEmpty();
            RuleFor(p => p.BarCode).MaximumLength(15);
            RuleFor(p => p.Doctor).MaximumLength(150);
            RuleFor(p => p.Prescription).MaximumLength(50);
            RuleFor(p => p.Invoice).MaximumLength(50);
            #endregion
        }

    }
}
