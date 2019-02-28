using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class FileDataCreateModelValidator
        : AbstractValidator<FileDataCreateModel>
    {
        public FileDataCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.FileName).NotEmpty();
            RuleFor(p => p.FileName).MaximumLength(250);
            RuleFor(p => p.Hash).MaximumLength(50);
            #endregion
        }

    }
}
