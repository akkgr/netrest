using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class BoardMinute
    {
        public BoardMinute()
        {
            #region Generated Constructor
            BoardMinuteSignatures = new HashSet<BoardMinuteSignature>();
            BoardMinuteSubjects = new HashSet<BoardMinuteSubject>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime MeetingDate { get; set; }

        public string Minutes { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime? Emailed { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual ICollection<BoardMinuteSignature> BoardMinuteSignatures { get; set; }

        public virtual ICollection<BoardMinuteSubject> BoardMinuteSubjects { get; set; }

        #endregion

    }
}
