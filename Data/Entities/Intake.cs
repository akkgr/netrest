using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Intake
    {
        public Intake()
        {
            #region Generated Constructor
            CardIntakes = new HashSet<CardIntake>();
            ProductTransactions = new HashSet<ProductTransaction>();
            Referrals = new HashSet<Referral>();
            NewReferrals = new HashSet<Referral>();
            Treatments = new HashSet<Treatment>();
            EmployeeIntakes = new HashSet<EmployeeIntake>();
            IntakeAbsences = new HashSet<IntakeAbsence>();
            AppointmentIntakes = new HashSet<AppointmentIntake>();
            IntakePlans = new HashSet<IntakePlan>();
            ItemTransactions = new HashSet<ItemTransaction>();
            Assets = new HashSet<Asset>();
            Assignments = new HashSet<Assignment>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

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

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<CardIntake> CardIntakes { get; set; }

        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }

        public virtual ICollection<Referral> Referrals { get; set; }

        public virtual ICollection<Referral> NewReferrals { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Volunteer Volunteer { get; set; }

        public virtual ICollection<EmployeeIntake> EmployeeIntakes { get; set; }

        public virtual DocRank DocRank { get; set; }

        public virtual Education Education { get; set; }

        public virtual Marital StatusMarital { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<IntakeAbsence> IntakeAbsences { get; set; }

        public virtual ICollection<AppointmentIntake> AppointmentIntakes { get; set; }

        public virtual ICollection<IntakePlan> IntakePlans { get; set; }

        public virtual ICollection<ItemTransaction> ItemTransactions { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }

        #endregion

    }
}
