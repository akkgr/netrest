using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ArchiveSubCategoryUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
