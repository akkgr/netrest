using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ItemGroup
    {
        public ItemGroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int ItemId { get; set; }

        public decimal Quantity { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public string GroupId { get; set; }

        public string GroupName { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Item Item { get; set; }

        #endregion

    }
}
