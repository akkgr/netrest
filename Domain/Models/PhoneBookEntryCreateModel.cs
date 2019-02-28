using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class PhoneBookEntryCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Company { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Phone4 { get; set; }

        public string Fax { get; set; }

        public string Remarks { get; set; }

        public int DocRankId { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        #endregion

    }
}
