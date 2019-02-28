using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class BudgetUpdateModelValidator
        : AbstractValidator<BudgetUpdateModel>
    {
        public BudgetUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ActivityCode).MaximumLength(10);
            #endregion
        }

    }
}
