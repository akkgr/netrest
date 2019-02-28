using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ArchiveSubCategory
    {
        public ArchiveSubCategory()
        {
            #region Generated Constructor
            SubCategoryArchives = new HashSet<Archive>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Archive> SubCategoryArchives { get; set; }

        public virtual ArchiveCategory CategoryArchiveCategory { get; set; }

        #endregion

    }
}
