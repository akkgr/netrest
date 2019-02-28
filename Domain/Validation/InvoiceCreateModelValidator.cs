using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class InvoiceCreateModelValidator
        : AbstractValidator<InvoiceCreateModel>
    {
        public InvoiceCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CompanyTitle).NotEmpty();
            RuleFor(p => p.CompanyTitle).MaximumLength(250);
            RuleFor(p => p.CompanyAFM).NotEmpty();
            RuleFor(p => p.CompanyAFM).MaximumLength(9);
            RuleFor(p => p.TransactionTitle).NotEmpty();
            RuleFor(p => p.TransactionTitle).MaximumLength(50);
            RuleFor(p => p.InvoiceTitle).NotEmpty();
            RuleFor(p => p.InvoiceTitle).MaximumLength(50);
            RuleFor(p => p.InvoiceNumber).NotEmpty();
            RuleFor(p => p.InvoiceNumber).MaximumLength(50);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(10);
            RuleFor(p => p.ChequeNumber).MaximumLength(50);
            #endregion
        }

    }
}
