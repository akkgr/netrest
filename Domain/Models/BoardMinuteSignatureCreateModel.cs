using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BoardMinuteSignatureCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int BoardminuteId { get; set; }

        public int BoardMemberId { get; set; }

        public string Title { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Signature { get; set; }

        public bool Signed { get; set; }

        #endregion

    }
}
