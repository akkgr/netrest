using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class AutoHistoryCreateModelValidator
        : AbstractValidator<AutoHistoryCreateModel>
    {
        public AutoHistoryCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.RowId).NotEmpty();
            RuleFor(p => p.RowId).MaximumLength(50);
            RuleFor(p => p.TableName).NotEmpty();
            RuleFor(p => p.TableName).MaximumLength(128);
            #endregion
        }

    }
}
