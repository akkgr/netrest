using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class IntakeUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public DateTime? DateIn { get; set; }

        public DateTime? Received { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public int? MaritalStatusId { get; set; }

        public int? EducationId { get; set; }

        public string Job { get; set; }

        public string Insurance { get; set; }

        public string Afm { get; set; }

        public string Adt { get; set; }

        public string Amka { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Resident { get; set; }

        public string Registered { get; set; }

        public string Request { get; set; }

        public string Reference { get; set; }

        public string Remarks { get; set; }

        public int DocRankId { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public int? Status { get; set; }

        public DateTime? Status0From { get; set; }

        public DateTime? Status0To { get; set; }

        public DateTime? Status1From { get; set; }

        public DateTime? Status1To { get; set; }

        public DateTime? Status2From { get; set; }

        public DateTime? Status2To { get; set; }

        public DateTime? Status3From { get; set; }

        public DateTime? Status3To { get; set; }

        public string BarCode { get; set; }

        public Byte[] Photo { get; set; }

        public int IntakeType { get; set; }

        public string School { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public string Languages { get; set; }

        public string OtherInfo { get; set; }

        public int? Sex { get; set; }

        #endregion

    }
}
