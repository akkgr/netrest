using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ItemGroupCreateModelValidator
        : AbstractValidator<ItemGroupCreateModel>
    {
        public ItemGroupCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.GroupId).MaximumLength(50);
            RuleFor(p => p.GroupName).MaximumLength(50);
            #endregion
        }

    }
}
