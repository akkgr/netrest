using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class PhoneBookEntryUpdateModelValidator
        : AbstractValidator<PhoneBookEntryUpdateModel>
    {
        public PhoneBookEntryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.Company).MaximumLength(250);
            RuleFor(p => p.Address).MaximumLength(250);
            RuleFor(p => p.Email).MaximumLength(250);
            RuleFor(p => p.Phone1).MaximumLength(50);
            RuleFor(p => p.Phone2).MaximumLength(50);
            RuleFor(p => p.Phone3).MaximumLength(50);
            RuleFor(p => p.Phone4).MaximumLength(50);
            RuleFor(p => p.Fax).MaximumLength(50);
            #endregion
        }

    }
}
