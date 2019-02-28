using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class DivisionJobCreateModelValidator
        : AbstractValidator<DivisionJobCreateModel>
    {
        public DivisionJobCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Job).NotEmpty();
            #endregion
        }

    }
}
