using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ClientHistory
    {
        public ClientHistory()
        {
            #region Generated Constructor
            ClientHistoryServices = new HashSet<ClientHistoryService>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int Clientid { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Referral { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MotherName { get; set; }

        public string FatherName { get; set; }

        public int? InsurerId { get; set; }

        public string Amka { get; set; }

        public string Amy { get; set; }

        public string Afm { get; set; }

        public DateTime? BirthDate { get; set; }

        public int? MaritalStatusId { get; set; }

        public int? IncomeId { get; set; }

        public string IncomeRemarks { get; set; }

        public int? Sex { get; set; }

        public int? EducationId { get; set; }

        public string Address { get; set; }

        public int? StayAreaId { get; set; }

        public int? House { get; set; }

        public int? RegisterAreaId { get; set; }

        public string Phone { get; set; }

        public int? Job { get; set; }

        public string JobComment { get; set; }

        public int? Ealth { get; set; }

        public string HealthComment { get; set; }

        public DateTime? ValidUntil { get; set; }

        public int? Active { get; set; }

        public int? WorkYears { get; set; }

        public int? NoWorkYears { get; set; }

        public int? ReferenceTo { get; set; }

        public string ReferenceToComment { get; set; }

        public int? EKOId { get; set; }

        public string Comment { get; set; }

        public string BarCode { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public bool? Domestic { get; set; }

        public Byte[] Photo { get; set; }

        public string RealEstate { get; set; }

        public string Loan { get; set; }

        public string IdCard { get; set; }

        public string StayPermit { get; set; }

        public string StayPermitDuration { get; set; }

        public string DependentsIncome { get; set; }

        public int? Members { get; set; }

        public int? MaleMembers { get; set; }

        public int? FemaleMembers { get; set; }

        public int? Children { get; set; }

        public int? ChildrenAbove14 { get; set; }

        public string Mobile { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<ClientHistoryService> ClientHistoryServices { get; set; }

        public virtual Client Client { get; set; }

        public virtual ClientStatuses ActiveClientStatuses { get; set; }

        public virtual Education Education { get; set; }

        public virtual Eko Eko { get; set; }

        public virtual Income Income { get; set; }

        public virtual Insurer Insurer { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual County RegisterAreaCounty { get; set; }

        public virtual County StayAreaCounty { get; set; }

        public virtual User User { get; set; }

        public virtual Marital StatusMarital { get; set; }

        #endregion

    }
}
