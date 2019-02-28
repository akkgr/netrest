using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BoardMemberCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Adt { get; set; }

        public int Position { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Decision { get; set; }

        public string Signature { get; set; }

        public int OrgTreeNodeId { get; set; }

        public string Email { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
