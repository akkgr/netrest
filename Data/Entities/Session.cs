using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Session
    {
        public Session()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime DateIn { get; set; }

        public int ClientId { get; set; }

        public bool? Ppointment { get; set; }

        public string Comment { get; set; }

        public string Subject { get; set; }

        public string Estimation { get; set; }

        public string Valuation { get; set; }

        public string Bjectives { get; set; }

        public int? Members { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Client Client { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
