using System;
using FluentValidation;
using Sca.Domain.Models;

namespace Sca.Domain.Validation
{
    public partial class MedicalExpenseCreateModelValidator
        : AbstractValidator<MedicalExpenseCreateModel>
    {
        public MedicalExpenseCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
