using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class WorkGroup
    {
        public WorkGroup()
        {
            #region Generated Constructor
            Appointments = new HashSet<Appointment>();
            Moderators = new HashSet<Moderator>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int? WorkGroupTypeId { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public string Remarks { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        public virtual WorkGroupType WorkGroupType { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<Moderator> Moderators { get; set; }

        #endregion

    }
}
