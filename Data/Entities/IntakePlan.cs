using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class IntakePlan
    {
        public IntakePlan()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int IntakeId { get; set; }

        public int UserId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int? EducationId { get; set; }

        public int? MaritalStatusId { get; set; }

        public string Job { get; set; }

        public DateTime? ContractDate { get; set; }

        public DateTime? ContractRenewal1 { get; set; }

        public DateTime? ContractRenewal2 { get; set; }

        public DateTime? ContractRenewal3 { get; set; }

        public string MainDiagnosis { get; set; }

        public string SecondaryDiagnosis { get; set; }

        public string Medication { get; set; }

        public string Doctor { get; set; }

        public string Nurses { get; set; }

        public string LastRelapse { get; set; }

        public string DiseaseStart { get; set; }

        public string Other { get; set; }

        public string ClinicalFocus { get; set; }

        public string Evaluation { get; set; }

        public string Psychometric { get; set; }

        public string SelfPlan { get; set; }

        public string FamilyPlan { get; set; }

        public int OrgTreeNodeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Education Education { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual Marital StatusMarital { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
