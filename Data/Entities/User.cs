using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class User
    {
        public User()
        {
            #region Generated Constructor
            Candidates = new HashSet<Candidate>();
            Cards = new HashSet<Card>();
            PhoneBookEntries = new HashSet<PhoneBookEntry>();
            ProductTransactions = new HashSet<ProductTransaction>();
            Receipts = new HashSet<Receipt>();
            Clients = new HashSet<Client>();
            FromReferrals = new HashSet<Referral>();
            ToReferrals = new HashSet<Referral>();
            EmployeeRequests = new HashSet<Request>();
            ApprovedByRequests = new HashSet<Request>();
            Sessions = new HashSet<Session>();
            Traders = new HashSet<Trader>();
            Treatments = new HashSet<Treatment>();
            DepartmentUsers = new HashSet<DepartmentUser>();
            ClientHistories = new HashSet<ClientHistory>();
            UserClaims = new HashSet<UserClaim>();
            UserDivisions = new HashSet<UserDivision>();
            UserLogins = new HashSet<UserLogin>();
            UserOrgs = new HashSet<UserOrg>();
            UserRoles = new HashSet<UserRole>();
            Documents = new HashSet<Document>();
            DocUsers = new HashSet<DocUser>();
            WorkGroups = new HashSet<WorkGroup>();
            Employees = new HashSet<Employee>();
            InfoMessages = new HashSet<InfoMessage>();
            InfoMessageRecipients = new HashSet<InfoMessageRecipient>();
            Intakes = new HashSet<Intake>();
            Applicants = new HashSet<Applicant>();
            Appointments = new HashSet<Appointment>();
            IntakePlans = new HashSet<IntakePlan>();
            Archives = new HashSet<Archive>();
            Invoices = new HashSet<Invoice>();
            ItemTransactions = new HashSet<ItemTransaction>();
            Assets = new HashSet<Asset>();
            EmployeeLeaves = new HashSet<Leave>();
            AssetTransactions = new HashSet<AssetTransaction>();
            Moderators = new HashSet<Moderator>();
            NodeToNodes = new HashSet<NodeToNode>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        public string BarCode { get; set; }

        public int? SecRank { get; set; }

        public bool TermsAccepted { get; set; }

        public int? EmployeeId { get; set; }

        public Byte[] RowVersion { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string Email { get; set; }

        public int AccessFailedCount { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public bool ResetPassword { get; set; }

        public string NormalizedUserName { get; set; }

        public string ConcurrencyStamp { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public string NormalizedEmail { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Candidate> Candidates { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

        public virtual ICollection<PhoneBookEntry> PhoneBookEntries { get; set; }

        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<Referral> FromReferrals { get; set; }

        public virtual ICollection<Referral> ToReferrals { get; set; }

        public virtual ICollection<Request> EmployeeRequests { get; set; }

        public virtual ICollection<Request> ApprovedByRequests { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<Trader> Traders { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }

        public virtual ICollection<DepartmentUser> DepartmentUsers { get; set; }

        public virtual ICollection<ClientHistory> ClientHistories { get; set; }

        public virtual DocRank SecRankDocRank { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<UserClaim> UserClaims { get; set; }

        public virtual ICollection<UserDivision> UserDivisions { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }

        public virtual ICollection<UserOrg> UserOrgs { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<Document> Documents { get; set; }

        public virtual ICollection<DocUser> DocUsers { get; set; }

        public virtual ICollection<WorkGroup> WorkGroups { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<InfoMessage> InfoMessages { get; set; }

        public virtual ICollection<InfoMessageRecipient> InfoMessageRecipients { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public virtual ICollection<Applicant> Applicants { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<IntakePlan> IntakePlans { get; set; }

        public virtual ICollection<Archive> Archives { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual ICollection<ItemTransaction> ItemTransactions { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }

        public virtual ICollection<Leave> EmployeeLeaves { get; set; }

        public virtual ICollection<AssetTransaction> AssetTransactions { get; set; }

        public virtual ICollection<Moderator> Moderators { get; set; }

        public virtual ICollection<NodeToNode> NodeToNodes { get; set; }

        #endregion

    }
}
