using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class DocGroupUpdateModelValidator
        : AbstractValidator<DocGroupUpdateModel>
    {
        public DocGroupUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(250);
            #endregion
        }

    }
}
