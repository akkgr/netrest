using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FileLinkUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int FileDataId { get; set; }

        public string EntityType { get; set; }

        public int EntityId { get; set; }

        public string FileName { get; set; }

        public int? TypeId { get; set; }

        public bool? IsPrivate { get; set; }

        public DateTime? PublicationDate { get; set; }

        #endregion

    }
}
