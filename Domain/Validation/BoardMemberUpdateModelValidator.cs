using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class BoardMemberUpdateModelValidator
        : AbstractValidator<BoardMemberUpdateModel>
    {
        public BoardMemberUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).MaximumLength(50);
            RuleFor(p => p.Adt).MaximumLength(50);
            RuleFor(p => p.Email).MaximumLength(150);
            #endregion
        }

    }
}
