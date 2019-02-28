using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DocRankReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int Rank { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
