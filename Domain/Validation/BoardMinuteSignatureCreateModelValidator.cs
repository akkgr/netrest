using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class BoardMinuteSignatureCreateModelValidator
        : AbstractValidator<BoardMinuteSignatureCreateModel>
    {
        public BoardMinuteSignatureCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.LastName).MaximumLength(50);
            RuleFor(p => p.FirstName).MaximumLength(50);
            #endregion
        }

    }
}
