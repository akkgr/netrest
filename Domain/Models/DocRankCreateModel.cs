using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DocRankCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public int Rank { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
