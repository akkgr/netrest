using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class FileData
    {
        public FileData()
        {
            #region Generated Constructor
            FileLinks = new HashSet<FileLink>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public Guid UnqId { get; set; }

        public string FileName { get; set; }

        public Byte[] RowVersion { get; set; }

        public string Hash { get; set; }

        public bool Compressed { get; set; }

        public bool? Uploaded { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<FileLink> FileLinks { get; set; }

        #endregion

    }
}
