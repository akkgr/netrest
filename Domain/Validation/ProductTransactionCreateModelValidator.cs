using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ProductTransactionCreateModelValidator
        : AbstractValidator<ProductTransactionCreateModel>
    {
        public ProductTransactionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Product).NotEmpty();
            RuleFor(p => p.Product).MaximumLength(250);
            RuleFor(p => p.TransactionCause).MaximumLength(250);
            #endregion
        }

    }
}
