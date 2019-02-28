using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class ClientStatusesUpdateModelValidator
        : AbstractValidator<ClientStatusesUpdateModel>
    {
        public ClientStatusesUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.Color).MaximumLength(50);
            #endregion
        }

    }
}
