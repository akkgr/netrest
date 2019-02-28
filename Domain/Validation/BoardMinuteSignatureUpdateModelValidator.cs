using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class BoardMinuteSignatureUpdateModelValidator
        : AbstractValidator<BoardMinuteSignatureUpdateModel>
    {
        public BoardMinuteSignatureUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).MaximumLength(50);
            #endregion
        }

    }
}
