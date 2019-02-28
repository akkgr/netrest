using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class BoardMinuteSubjectUpdateModelValidator
        : AbstractValidator<BoardMinuteSubjectUpdateModel>
    {
        public BoardMinuteSubjectUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Sn).MaximumLength(50);
            #endregion
        }

    }
}
