using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DocRankUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public int Rank { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
