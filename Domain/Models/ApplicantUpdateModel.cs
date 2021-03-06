using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ApplicantUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string ApplicationNumber { get; set; }

        public string ApplicationCode { get; set; }

        public string Publication { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string Adt { get; set; }

        public string Amka { get; set; }

        public string Afm { get; set; }

        public int? Sex { get; set; }

        public DateTime? BirthDate { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string StreetNumber { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public int? DegreeId { get; set; }

        public int? SpecialtyId { get; set; }

        public int? Points { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int? UserId { get; set; }

        public string Remarks { get; set; }

        public string RemarksPublic { get; set; }

        public string Result { get; set; }

        public Byte[] Photo { get; set; }

        #endregion

    }
}
