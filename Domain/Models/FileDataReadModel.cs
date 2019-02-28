using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FileDataReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public Guid UnqId { get; set; }

        public string FileName { get; set; }

        public Byte[] RowVersion { get; set; }

        public string Hash { get; set; }

        public bool Compressed { get; set; }

        public bool? Uploaded { get; set; }

        #endregion

    }
}
