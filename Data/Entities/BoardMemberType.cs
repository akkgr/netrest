using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class BoardMemberType
    {
        public BoardMemberType()
        {
            #region Generated Constructor
            PositionBoardMembers = new HashSet<BoardMember>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<BoardMember> PositionBoardMembers { get; set; }

        #endregion

    }
}
