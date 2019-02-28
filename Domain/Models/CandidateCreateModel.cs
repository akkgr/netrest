using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class CandidateCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Adt { get; set; }

        public string Afm { get; set; }

        public string Address { get; set; }

        public string StreetNumber { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public int? WorkPositionId { get; set; }

        public int? InterestId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int? RankId { get; set; }

        public int? UserId { get; set; }

        public DateTime? Inserted { get; set; }

        #endregion

    }
}
