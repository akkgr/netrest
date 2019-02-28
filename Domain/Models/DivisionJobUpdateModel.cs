using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DivisionJobUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int DivisionId { get; set; }

        public DateTime ChangeDate { get; set; }

        public string Job { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
