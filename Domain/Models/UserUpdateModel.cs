using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        public string BarCode { get; set; }

        public int? SecRank { get; set; }

        public bool TermsAccepted { get; set; }

        public int? EmployeeId { get; set; }

        public Byte[] RowVersion { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string Email { get; set; }

        public int AccessFailedCount { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public bool ResetPassword { get; set; }

        public string NormalizedUserName { get; set; }

        public string ConcurrencyStamp { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public string NormalizedEmail { get; set; }

        #endregion

    }
}
