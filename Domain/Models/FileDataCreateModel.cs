using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FileDataCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public Guid UnqId { get; set; }

        public string FileName { get; set; }

        public string Hash { get; set; }

        public bool Compressed { get; set; }

        public bool? Uploaded { get; set; }

        #endregion

    }
}
