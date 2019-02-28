using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ArchiveCategory
    {
        public ArchiveCategory()
        {
            #region Generated Constructor
            CategoryArchives = new HashSet<Archive>();
            CategoryArchiveSubCategories = new HashSet<ArchiveSubCategory>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Archive> CategoryArchives { get; set; }

        public virtual ICollection<ArchiveSubCategory> CategoryArchiveSubCategories { get; set; }

        #endregion

    }
}
