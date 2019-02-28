using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class TraderUpdateModelValidator
        : AbstractValidator<TraderUpdateModel>
    {
        public TraderUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(250);
            RuleFor(p => p.BarCode).MaximumLength(50);
            RuleFor(p => p.ContractNo).MaximumLength(50);
            RuleFor(p => p.Afm).MaximumLength(9);
            RuleFor(p => p.Description).MaximumLength(250);
            RuleFor(p => p.Amount).MaximumLength(250);
            #endregion
        }

    }
}
