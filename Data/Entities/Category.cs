using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Category
    {
        public Category()
        {
            #region Generated Constructor
            Items = new HashSet<Item>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Item> Items { get; set; }

        #endregion

    }
}
