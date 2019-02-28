using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class FileLink
    {
        public FileLink()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int FileDataId { get; set; }

        public string EntityType { get; set; }

        public int EntityId { get; set; }

        public string FileName { get; set; }

        public int? TypeId { get; set; }

        public bool? IsPrivate { get; set; }

        public DateTime? PublicationDate { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AttachmentType TypeAttachmentType { get; set; }

        public virtual FileData FileData { get; set; }

        #endregion

    }
}
