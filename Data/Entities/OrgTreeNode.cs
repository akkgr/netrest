using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class OrgTreeNode
    {
        public OrgTreeNode()
        {
            #region Generated Constructor
            Candidates = new HashSet<Candidate>();
            Cards = new HashSet<Card>();
            PhoneBookEntries = new HashSet<PhoneBookEntry>();
            Presences = new HashSet<Presence>();
            ProductTransactions = new HashSet<ProductTransaction>();
            Receipts = new HashSet<Receipt>();
            Clients = new HashSet<Client>();
            ClientHistoryServices = new HashSet<ClientHistoryService>();
            FromOrgReferrals = new HashSet<Referral>();
            ToOrgReferrals = new HashSet<Referral>();
            ClientServices = new HashSet<ClientService>();
            Requests = new HashSet<Request>();
            Sessions = new HashSet<Session>();
            DailyFoodMenus = new HashSet<DailyFoodMenu>();
            Traders = new HashSet<Trader>();
            Treatments = new HashSet<Treatment>();
            ClientHistories = new HashSet<ClientHistory>();
            UserOrgs = new HashSet<UserOrg>();
            Documents = new HashSet<Document>();
            WorkGroups = new HashSet<WorkGroup>();
            BoardMembers = new HashSet<BoardMember>();
            WorkingHours = new HashSet<WorkingHour>();
            BoardMinutes = new HashSet<BoardMinute>();
            EmployeeIntakes = new HashSet<EmployeeIntake>();
            EmployeeOrgs = new HashSet<EmployeeOrg>();
            EmployeePayments = new HashSet<EmployeePayment>();
            Budgets = new HashSet<Budget>();
            Intakes = new HashSet<Intake>();
            Applicants = new HashSet<Applicant>();
            Appointments = new HashSet<Appointment>();
            IntakePlans = new HashSet<IntakePlan>();
            Archives = new HashSet<Archive>();
            Invoices = new HashSet<Invoice>();
            CompanyNodeInvoices = new HashSet<Invoice>();
            VirtualNodeInvoices = new HashSet<Invoice>();
            Items = new HashSet<Item>();
            ItemTransactions = new HashSet<ItemTransaction>();
            Assets = new HashSet<Asset>();
            FirstAssets = new HashSet<Asset>();
            Leaves = new HashSet<Leave>();
            OrgFromAssetTransactions = new HashSet<AssetTransaction>();
            OrgToAssetTransactions = new HashSet<AssetTransaction>();
            ParentNodeNodeToNodes = new HashSet<NodeToNode>();
            ChildNodeNodeToNodes = new HashSet<NodeToNode>();
            ParentOrgTreeNodes = new HashSet<OrgTreeNode>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int NodeId { get; set; }

        public string Code { get; set; }

        public bool IsActive { get; set; }

        public int? ViewOrder { get; set; }

        public string AppObject { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Candidate> Candidates { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

        public virtual ICollection<PhoneBookEntry> PhoneBookEntries { get; set; }

        public virtual ICollection<Presence> Presences { get; set; }

        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<ClientHistoryService> ClientHistoryServices { get; set; }

        public virtual ICollection<Referral> FromOrgReferrals { get; set; }

        public virtual ICollection<Referral> ToOrgReferrals { get; set; }

        public virtual ICollection<ClientService> ClientServices { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<DailyFoodMenu> DailyFoodMenus { get; set; }

        public virtual ICollection<Trader> Traders { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; }

        public virtual ICollection<ClientHistory> ClientHistories { get; set; }

        public virtual ICollection<UserOrg> UserOrgs { get; set; }

        public virtual ICollection<Document> Documents { get; set; }

        public virtual ICollection<WorkGroup> WorkGroups { get; set; }

        public virtual ICollection<BoardMember> BoardMembers { get; set; }

        public virtual ICollection<WorkingHour> WorkingHours { get; set; }

        public virtual ICollection<BoardMinute> BoardMinutes { get; set; }

        public virtual ICollection<EmployeeIntake> EmployeeIntakes { get; set; }

        public virtual ICollection<EmployeeOrg> EmployeeOrgs { get; set; }

        public virtual ICollection<EmployeePayment> EmployeePayments { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public virtual ICollection<Applicant> Applicants { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<IntakePlan> IntakePlans { get; set; }

        public virtual ICollection<Archive> Archives { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual ICollection<Invoice> CompanyNodeInvoices { get; set; }

        public virtual ICollection<Invoice> VirtualNodeInvoices { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public virtual ICollection<ItemTransaction> ItemTransactions { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }

        public virtual ICollection<Asset> FirstAssets { get; set; }

        public virtual ICollection<Leave> Leaves { get; set; }

        public virtual ICollection<AssetTransaction> OrgFromAssetTransactions { get; set; }

        public virtual ICollection<AssetTransaction> OrgToAssetTransactions { get; set; }

        public virtual ICollection<NodeToNode> ParentNodeNodeToNodes { get; set; }

        public virtual ICollection<NodeToNode> ChildNodeNodeToNodes { get; set; }

        public virtual OrgNode NodeOrgNode { get; set; }

        public virtual OrgTreeNode ParentOrgTreeNode { get; set; }

        public virtual ICollection<OrgTreeNode> ParentOrgTreeNodes { get; set; }

        #endregion

    }
}
