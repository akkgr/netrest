using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DocRank
    {
        public DocRank()
        {
            #region Generated Constructor
            RankCandidates = new HashSet<Candidate>();
            RankCards = new HashSet<Card>();
            PhoneBookEntries = new HashSet<PhoneBookEntry>();
            RankReceipts = new HashSet<Receipt>();
            RankPublications = new HashSet<Publication>();
            RankTraders = new HashSet<Trader>();
            SecRankUsers = new HashSet<User>();
            RankDocuments = new HashSet<Document>();
            SecRankEmployees = new HashSet<Employee>();
            Intakes = new HashSet<Intake>();
            RankAppointments = new HashSet<Appointment>();
            RankAppointmentIntakes = new HashSet<AppointmentIntake>();
            RankArchives = new HashSet<Archive>();
            Invoices = new HashSet<Invoice>();
            RankAssets = new HashSet<Asset>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int Rank { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Candidate> RankCandidates { get; set; }

        public virtual ICollection<Card> RankCards { get; set; }

        public virtual ICollection<PhoneBookEntry> PhoneBookEntries { get; set; }

        public virtual ICollection<Receipt> RankReceipts { get; set; }

        public virtual ICollection<Publication> RankPublications { get; set; }

        public virtual ICollection<Trader> RankTraders { get; set; }

        public virtual ICollection<User> SecRankUsers { get; set; }

        public virtual ICollection<Document> RankDocuments { get; set; }

        public virtual ICollection<Employee> SecRankEmployees { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public virtual ICollection<Appointment> RankAppointments { get; set; }

        public virtual ICollection<AppointmentIntake> RankAppointmentIntakes { get; set; }

        public virtual ICollection<Archive> RankArchives { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual ICollection<Asset> RankAssets { get; set; }

        #endregion

    }
}
