using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class AssetType
    {
        public AssetType()
        {
            #region Generated Constructor
            Assets = new HashSet<Asset>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Asset> Assets { get; set; }

        #endregion

    }
}
