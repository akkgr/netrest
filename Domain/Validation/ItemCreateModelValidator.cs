using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ItemCreateModelValidator
        : AbstractValidator<ItemCreateModel>
    {
        public ItemCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(150);
            RuleFor(p => p.BarCode).NotEmpty();
            RuleFor(p => p.BarCode).MaximumLength(15);
            RuleFor(p => p.Company).MaximumLength(100);
            RuleFor(p => p.ActiveSubstance).MaximumLength(100);
            #endregion
        }

    }
}
