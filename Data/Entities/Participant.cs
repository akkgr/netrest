using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Participant
    {
        public Participant()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int AssignmentId { get; set; }

        public int ParticipantId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Assignment Assignment { get; set; }

        public virtual Employee Employee { get; set; }

        #endregion

    }
}
