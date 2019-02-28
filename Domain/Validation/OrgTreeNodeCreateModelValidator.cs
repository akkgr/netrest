using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class OrgTreeNodeCreateModelValidator
        : AbstractValidator<OrgTreeNodeCreateModel>
    {
        public OrgTreeNodeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Code).NotEmpty();
            RuleFor(p => p.Code).MaximumLength(50);
            #endregion
        }

    }
}
