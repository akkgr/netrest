using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class FlowChartStepCreateModelValidator
        : AbstractValidator<FlowChartStepCreateModel>
    {
        public FlowChartStepCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(150);
            #endregion
        }

    }
}
