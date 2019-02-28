using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class OrgNodeUpdateModelValidator
        : AbstractValidator<OrgNodeUpdateModel>
    {
        public OrgNodeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(50);
            RuleFor(p => p.AppObject).MaximumLength(50);
            #endregion
        }

    }
}
