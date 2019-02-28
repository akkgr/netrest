using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class BoardMember
    {
        public BoardMember()
        {
            #region Generated Constructor
            BoardMinuteSignatures = new HashSet<BoardMinuteSignature>();
            #endregion
        }

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

        #region Generated Relationships
        public virtual BoardMemberType PositionBoardMemberType { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual ICollection<BoardMinuteSignature> BoardMinuteSignatures { get; set; }

        #endregion

    }
}
