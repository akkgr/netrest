using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class DivisionJobUpdateModelValidator
        : AbstractValidator<DivisionJobUpdateModel>
    {
        public DivisionJobUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Job).NotEmpty();
            #endregion
        }

    }
}
