using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class PublicationCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int SerialNumber { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int RankId { get; set; }

        public bool IsActive { get; set; }

        #endregion

    }
}
