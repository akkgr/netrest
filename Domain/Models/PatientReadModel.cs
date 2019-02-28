using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class PatientReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int? PopulationCategory { get; set; }

        public string PopulationCategoryNote { get; set; }

        public bool? OtherProgram { get; set; }

        public string OtherProgramNote { get; set; }

        public string Diagnosis { get; set; }

        public string DoubleDiagnosis { get; set; }

        public string Medication { get; set; }

        public string DrugRelation { get; set; }

        public string Doctor { get; set; }

        public string DoctorRelation { get; set; }

        public string FunctionalLevels { get; set; }

        public string Rehabilitation { get; set; }

        public string Willingness { get; set; }

        public string Cooperation { get; set; }

        public bool? OtherTherapist { get; set; }

        public string OtherTherapistNote { get; set; }

        public bool? MultiTeam { get; set; }

        public string MultiTeamNote { get; set; }

        public bool? OtherAgency { get; set; }

        public string OtherAgencyNote { get; set; }

        public string FreeTimeActivities { get; set; }

        public string DoctorName { get; set; }

        public string DoctorAMKA { get; set; }

        public int? DiseaseId { get; set; }

        public int? SecondDiseaseId { get; set; }

        public int? ThirdDiseaseId { get; set; }

        public int? Recursions { get; set; }

        public string SatisfactionMeasurement { get; set; }

        public string SatisfactionDegree { get; set; }

        public string TerminationReason { get; set; }

        #endregion

    }
}
