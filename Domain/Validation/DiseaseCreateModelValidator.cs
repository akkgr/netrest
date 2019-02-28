using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class DiseaseCreateModelValidator
        : AbstractValidator<DiseaseCreateModel>
    {
        public DiseaseCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(50);
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MaximumLength(250);
            #endregion
        }

    }
}
