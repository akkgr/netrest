using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class BudgetCreateModelValidator
        : AbstractValidator<BudgetCreateModel>
    {
        public BudgetCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ActivityCode).MaximumLength(10);
            #endregion
        }

    }
}
