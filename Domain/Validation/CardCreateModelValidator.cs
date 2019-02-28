using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class CardCreateModelValidator
        : AbstractValidator<CardCreateModel>
    {
        public CardCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
