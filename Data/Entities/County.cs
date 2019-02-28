using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class County
    {
        public County()
        {
            #region Generated Constructor
            RegisterAreaClients = new HashSet<Client>();
            StayAreaClients = new HashSet<Client>();
            RegisterAreaClientHistories = new HashSet<ClientHistory>();
            StayAreaClientHistories = new HashSet<ClientHistory>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Client> RegisterAreaClients { get; set; }

        public virtual ICollection<Client> StayAreaClients { get; set; }

        public virtual ICollection<ClientHistory> RegisterAreaClientHistories { get; set; }

        public virtual ICollection<ClientHistory> StayAreaClientHistories { get; set; }

        #endregion

    }
}
