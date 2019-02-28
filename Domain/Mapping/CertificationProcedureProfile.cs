using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CertificationProcedureProfile
        : AutoMapper.Profile
    {
        public CertificationProcedureProfile()
        {
            CreateMap<Sca.Data.Entities.CertificationProcedure, Sca.Domain.Models.CertificationProcedureReadModel>();
            CreateMap<Sca.Domain.Models.CertificationProcedureCreateModel, Sca.Data.Entities.CertificationProcedure>();
            CreateMap<Sca.Domain.Models.CertificationProcedureUpdateModel, Sca.Data.Entities.CertificationProcedure>();
        }

    }
}
