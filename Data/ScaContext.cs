using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sca.Data
{
    public partial class ScaContext : DbContext
    {
        public ScaContext(DbContextOptions<ScaContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Sca.Data.Entities.Packaging> Packagings { get; set; }

        public virtual DbSet<Sca.Data.Entities.Candidate> Candidates { get; set; }

        public virtual DbSet<Sca.Data.Entities.CandidateInterest> CandidateInterests { get; set; }

        public virtual DbSet<Sca.Data.Entities.DocRank> DocRanks { get; set; }

        public virtual DbSet<Sca.Data.Entities.OrgTreeNode> OrgTreeNodes { get; set; }

        public virtual DbSet<Sca.Data.Entities.User> Users { get; set; }

        public virtual DbSet<Sca.Data.Entities.WorkPosition> WorkPositions { get; set; }

        public virtual DbSet<Sca.Data.Entities.Parameter> Parameters { get; set; }

        public virtual DbSet<Sca.Data.Entities.Participant> Participants { get; set; }

        public virtual DbSet<Sca.Data.Entities.Assignment> Assignments { get; set; }

        public virtual DbSet<Sca.Data.Entities.Employee> Employees { get; set; }

        public virtual DbSet<Sca.Data.Entities.Card> Cards { get; set; }

        public virtual DbSet<Sca.Data.Entities.CardType> CardTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.CardClient> CardClients { get; set; }

        public virtual DbSet<Sca.Data.Entities.Client> Clients { get; set; }

        public virtual DbSet<Sca.Data.Entities.PaymentType> PaymentTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.CardEmployee> CardEmployees { get; set; }

        public virtual DbSet<Sca.Data.Entities.CardIntake> CardIntakes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Intake> Intakes { get; set; }

        public virtual DbSet<Sca.Data.Entities.PhoneBookEntry> PhoneBookEntries { get; set; }

        public virtual DbSet<Sca.Data.Entities.PublicationOrgNode> PublicationOrgNodes { get; set; }

        public virtual DbSet<Sca.Data.Entities.OrgNode> OrgNodes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Publication> Publications { get; set; }

        public virtual DbSet<Sca.Data.Entities.Presence> Presences { get; set; }

        public virtual DbSet<Sca.Data.Entities.Category> Categories { get; set; }

        public virtual DbSet<Sca.Data.Entities.ProductTransaction> ProductTransactions { get; set; }

        public virtual DbSet<Sca.Data.Entities.DailyFoodMenu> DailyFoodMenus { get; set; }

        public virtual DbSet<Sca.Data.Entities.Certification> Certifications { get; set; }

        public virtual DbSet<Sca.Data.Entities.PublicationDivision> PublicationDivisions { get; set; }

        public virtual DbSet<Sca.Data.Entities.Division> Divisions { get; set; }

        public virtual DbSet<Sca.Data.Entities.Receipt> Receipts { get; set; }

        public virtual DbSet<Sca.Data.Entities.ClientStatuses> ClientStatuses { get; set; }

        public virtual DbSet<Sca.Data.Entities.Education> Educations { get; set; }

        public virtual DbSet<Sca.Data.Entities.Eko> Ekos { get; set; }

        public virtual DbSet<Sca.Data.Entities.Income> Incomes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Insurer> Insurers { get; set; }

        public virtual DbSet<Sca.Data.Entities.County> Counties { get; set; }

        public virtual DbSet<Sca.Data.Entities.Marital> Maritals { get; set; }

        public virtual DbSet<Sca.Data.Entities.ClientHistoryService> ClientHistoryServices { get; set; }

        public virtual DbSet<Sca.Data.Entities.ClientHistory> ClientHistories { get; set; }

        public virtual DbSet<Sca.Data.Entities.Referral> Referrals { get; set; }

        public virtual DbSet<Sca.Data.Entities.ReferralLevel> ReferralLevels { get; set; }

        public virtual DbSet<Sca.Data.Entities.ClientService> ClientServices { get; set; }

        public virtual DbSet<Sca.Data.Entities.Request> Requests { get; set; }

        public virtual DbSet<Sca.Data.Entities.RequestType> RequestTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Company> Companies { get; set; }

        public virtual DbSet<Sca.Data.Entities.Doy> Doys { get; set; }

        public virtual DbSet<Sca.Data.Entities.ContractType> ContractTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Role> Roles { get; set; }

        public virtual DbSet<Sca.Data.Entities.Session> Sessions { get; set; }

        public virtual DbSet<Sca.Data.Entities.FoodMenu> FoodMenus { get; set; }

        public virtual DbSet<Sca.Data.Entities.Specialty> Specialties { get; set; }

        public virtual DbSet<Sca.Data.Entities.Degree> Degrees { get; set; }

        public virtual DbSet<Sca.Data.Entities.Trader> Traders { get; set; }

        public virtual DbSet<Sca.Data.Entities.Department> Departments { get; set; }

        public virtual DbSet<Sca.Data.Entities.TransactionType> TransactionTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.DepartmentCertification> DepartmentCertifications { get; set; }

        public virtual DbSet<Sca.Data.Entities.Treatment> Treatments { get; set; }

        public virtual DbSet<Sca.Data.Entities.DepartmentDivision> DepartmentDivisions { get; set; }

        public virtual DbSet<Sca.Data.Entities.TreatmentMedecine> TreatmentMedecines { get; set; }

        public virtual DbSet<Sca.Data.Entities.Doctor> Doctors { get; set; }

        public virtual DbSet<Sca.Data.Entities.Item> Items { get; set; }

        public virtual DbSet<Sca.Data.Entities.DepartmentUser> DepartmentUsers { get; set; }

        public virtual DbSet<Sca.Data.Entities.Unit> Units { get; set; }

        public virtual DbSet<Sca.Data.Entities.Disease> Diseases { get; set; }

        public virtual DbSet<Sca.Data.Entities.Patient> Patients { get; set; }

        public virtual DbSet<Sca.Data.Entities.UserClaim> UserClaims { get; set; }

        public virtual DbSet<Sca.Data.Entities.DivisionJob> DivisionJobs { get; set; }

        public virtual DbSet<Sca.Data.Entities.UserConnection> UserConnections { get; set; }

        public virtual DbSet<Sca.Data.Entities.DocDocGroup> DocDocGroups { get; set; }

        public virtual DbSet<Sca.Data.Entities.DocGroup> DocGroups { get; set; }

        public virtual DbSet<Sca.Data.Entities.Document> Documents { get; set; }

        public virtual DbSet<Sca.Data.Entities.UserDivision> UserDivisions { get; set; }

        public virtual DbSet<Sca.Data.Entities.UserLogin> UserLogins { get; set; }

        public virtual DbSet<Sca.Data.Entities.UserOrg> UserOrgs { get; set; }

        public virtual DbSet<Sca.Data.Entities.UserRole> UserRoles { get; set; }

        public virtual DbSet<Sca.Data.Entities.CertificationProcedure> CertificationProcedures { get; set; }

        public virtual DbSet<Sca.Data.Entities.Volunteer> Volunteers { get; set; }

        public virtual DbSet<Sca.Data.Entities.DocUser> DocUsers { get; set; }

        public virtual DbSet<Sca.Data.Entities.WorkGroup> WorkGroups { get; set; }

        public virtual DbSet<Sca.Data.Entities.WorkGroupType> WorkGroupTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.BoardMember> BoardMembers { get; set; }

        public virtual DbSet<Sca.Data.Entities.BoardMemberType> BoardMemberTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.WorkingHour> WorkingHours { get; set; }

        public virtual DbSet<Sca.Data.Entities.IntakeBenefit> IntakeBenefits { get; set; }

        public virtual DbSet<Sca.Data.Entities.BoardMinute> BoardMinutes { get; set; }

        public virtual DbSet<Sca.Data.Entities.EmploymentType> EmploymentTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Nationality> Nationalities { get; set; }

        public virtual DbSet<Sca.Data.Entities.EmployeeIntake> EmployeeIntakes { get; set; }

        public virtual DbSet<Sca.Data.Entities.EmployeeOrg> EmployeeOrgs { get; set; }

        public virtual DbSet<Sca.Data.Entities.AutoHistory> AutoHistories { get; set; }

        public virtual DbSet<Sca.Data.Entities.FlowChartStep> FlowChartSteps { get; set; }

        public virtual DbSet<Sca.Data.Entities.FlowChart> FlowCharts { get; set; }

        public virtual DbSet<Sca.Data.Entities.EmployeePayment> EmployeePayments { get; set; }

        public virtual DbSet<Sca.Data.Entities.FileData> FileDatas { get; set; }

        public virtual DbSet<Sca.Data.Entities.FileLink> FileLinks { get; set; }

        public virtual DbSet<Sca.Data.Entities.AttachmentType> AttachmentTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.InfoMessage> InfoMessages { get; set; }

        public virtual DbSet<Sca.Data.Entities.InfoMessageRecipient> InfoMessageRecipients { get; set; }

        public virtual DbSet<Sca.Data.Entities.Budget> Budgets { get; set; }

        public virtual DbSet<Sca.Data.Entities.ActivityCode> ActivityCodes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Applicant> Applicants { get; set; }

        public virtual DbSet<Sca.Data.Entities.IntakeAbsence> IntakeAbsences { get; set; }

        public virtual DbSet<Sca.Data.Entities.IntakeAbsenceType> IntakeAbsenceTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Appointment> Appointments { get; set; }

        public virtual DbSet<Sca.Data.Entities.AppointmentType> AppointmentTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.AppointmentIntake> AppointmentIntakes { get; set; }

        public virtual DbSet<Sca.Data.Entities.IntakePlan> IntakePlans { get; set; }

        public virtual DbSet<Sca.Data.Entities.AppointmentSpecialty> AppointmentSpecialties { get; set; }

        public virtual DbSet<Sca.Data.Entities.InvoiceType> InvoiceTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Archive> Archives { get; set; }

        public virtual DbSet<Sca.Data.Entities.ArchiveCategory> ArchiveCategories { get; set; }

        public virtual DbSet<Sca.Data.Entities.ArchiveSubCategory> ArchiveSubCategories { get; set; }

        public virtual DbSet<Sca.Data.Entities.Invoice> Invoices { get; set; }

        public virtual DbSet<Sca.Data.Entities.ItemGroup> ItemGroups { get; set; }

        public virtual DbSet<Sca.Data.Entities.ItemTransaction> ItemTransactions { get; set; }

        public virtual DbSet<Sca.Data.Entities.Origin> Origins { get; set; }

        public virtual DbSet<Sca.Data.Entities.Asset> Assets { get; set; }

        public virtual DbSet<Sca.Data.Entities.AssetType> AssetTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.Leave> Leaves { get; set; }

        public virtual DbSet<Sca.Data.Entities.DepartmentFlowChart> DepartmentFlowCharts { get; set; }

        public virtual DbSet<Sca.Data.Entities.AssetTransaction> AssetTransactions { get; set; }

        public virtual DbSet<Sca.Data.Entities.MedicalExpense> MedicalExpenses { get; set; }

        public virtual DbSet<Sca.Data.Entities.CertificationProcedurePublication> CertificationProcedurePublications { get; set; }

        public virtual DbSet<Sca.Data.Entities.Moderator> Moderators { get; set; }

        public virtual DbSet<Sca.Data.Entities.NodeToNode> NodeToNodes { get; set; }

        public virtual DbSet<Sca.Data.Entities.OrgNodeType> OrgNodeTypes { get; set; }

        public virtual DbSet<Sca.Data.Entities.BoardMinuteSignature> BoardMinuteSignatures { get; set; }

        public virtual DbSet<Sca.Data.Entities.BoardMinuteSubject> BoardMinuteSubjects { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PackagingMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CandidateMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CandidateInterestMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DocRankMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.OrgTreeNodeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.WorkPositionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ParameterMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ParticipantMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AssignmentMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EmployeeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CardMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CardTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CardClientMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ClientMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PaymentTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CardEmployeeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CardIntakeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.IntakeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PhoneBookEntryMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PublicationOrgNodeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.OrgNodeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PublicationMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PresenceMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CategoryMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ProductTransactionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DailyFoodMenuMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CertificationMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PublicationDivisionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DivisionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ReceiptMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ClientStatusesMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EducationMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EkoMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.IncomeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.InsurerMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CountyMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.MaritalMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ClientHistoryServiceMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ClientHistoryMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ReferralMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ReferralLevelMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ClientServiceMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.RequestMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.RequestTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CompanyMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DoyMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ContractTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.RoleMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.SessionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.FoodMenuMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.SpecialtyMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DegreeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.TraderMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DepartmentMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.TransactionTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DepartmentCertificationMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.TreatmentMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DepartmentDivisionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.TreatmentMedecineMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DoctorMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ItemMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DepartmentUserMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UnitMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DiseaseMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.PatientMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserClaimMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DivisionJobMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserConnectionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DocDocGroupMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DocGroupMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DocumentMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserDivisionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserLoginMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserOrgMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.UserRoleMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CertificationProcedureMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.VolunteerMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DocUserMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.WorkGroupMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.WorkGroupTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.BoardMemberMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.BoardMemberTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.WorkingHourMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.IntakeBenefitMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.BoardMinuteMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EmploymentTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.NationalityMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EmployeeIntakeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EmployeeOrgMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AutoHistoryMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.FlowChartStepMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.FlowChartMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.EmployeePaymentMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.FileDataMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.FileLinkMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AttachmentTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.InfoMessageMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.InfoMessageRecipientMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.BudgetMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ActivityCodeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ApplicantMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.IntakeAbsenceMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.IntakeAbsenceTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AppointmentMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AppointmentTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AppointmentIntakeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.IntakePlanMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AppointmentSpecialtyMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.InvoiceTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ArchiveMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ArchiveCategoryMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ArchiveSubCategoryMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.InvoiceMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ItemGroupMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ItemTransactionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.OriginMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AssetMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AssetTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.LeaveMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.DepartmentFlowChartMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.AssetTransactionMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.MedicalExpenseMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.CertificationProcedurePublicationMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.ModeratorMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.NodeToNodeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.OrgNodeTypeMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.BoardMinuteSignatureMap());
            modelBuilder.ApplyConfiguration(new Sca.Data.Mapping.BoardMinuteSubjectMap());
            #endregion
        }
    }
}
