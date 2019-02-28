using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class EmployeeUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string FatherLastName { get; set; }

        public string FatherFirstName { get; set; }

        public string MotherLastName { get; set; }

        public string MotherFirstName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Afm { get; set; }

        public DateTime? HireDate { get; set; }

        public int? MaritalStatusId { get; set; }

        public int? Children { get; set; }

        public int? EducationId { get; set; }

        public string EducationRemarks { get; set; }

        public int? SpecialtyId { get; set; }

        public int? PositionId { get; set; }

        public int? WorkExperience { get; set; }

        public int? IndustryExperience { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public int? DOYId { get; set; }

        public int? NationalityId { get; set; }

        public string IdCard { get; set; }

        public DateTime? IdCardDate { get; set; }

        public string AlienCard { get; set; }

        public string AlienPass { get; set; }

        public bool? FirstEmployment { get; set; }

        public int? EmploymentTypeId { get; set; }

        public int? ContractTypeId { get; set; }

        public string Contract { get; set; }

        public DateTime? ContractUntil { get; set; }

        public DateTime? ResignDate { get; set; }

        public string ResignRemarks { get; set; }

        public DateTime? DismissalDate { get; set; }

        public string DismissalRemarks { get; set; }

        public string ChangeRemarks { get; set; }

        public bool? RollingSchedule { get; set; }

        public string ScheduleRemarks { get; set; }

        public bool? Oaed { get; set; }

        public bool? MainJob { get; set; }

        public bool? SecondaryJob { get; set; }

        public int? FirstInsuranceYear { get; set; }

        public string InsuranceNumber { get; set; }

        public string Amka { get; set; }

        public string Salary { get; set; }

        public string SalaryExtra { get; set; }

        public bool? EducationCopies { get; set; }

        public bool? EmploymentCopies { get; set; }

        public bool? MaritalStatusCopies { get; set; }

        public string Copies { get; set; }

        public string Remarks { get; set; }

        public string Kad { get; set; }

        public string SpecialtyCode { get; set; }

        public string InsurancePack { get; set; }

        public string SpecialInsurance { get; set; }

        public string BarCode { get; set; }

        public int? SecRank { get; set; }

        public string Languages { get; set; }

        public string Bank { get; set; }

        public string BankAccount { get; set; }

        public Byte[] Photo { get; set; }

        public int UserId { get; set; }

        public string RemarksAdmin { get; set; }

        public string Notes { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
