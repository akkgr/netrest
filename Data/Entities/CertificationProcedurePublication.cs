using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class CertificationProcedurePublication
    {
        public CertificationProcedurePublication()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int ProcedureId { get; set; }

        public int PublicationId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual CertificationProcedure ProcedureCertificationProcedure { get; set; }

        public virtual Publication Publication { get; set; }

        #endregion

    }
}
