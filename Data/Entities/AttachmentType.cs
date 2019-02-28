using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class AttachmentType
    {
        public AttachmentType()
        {
            #region Generated Constructor
            TypeFileLinks = new HashSet<FileLink>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Publish { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<FileLink> TypeFileLinks { get; set; }

        #endregion

    }
}
