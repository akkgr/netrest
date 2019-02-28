using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CertificationProcedurePublicationProfile
        : AutoMapper.Profile
    {
        public CertificationProcedurePublicationProfile()
        {
            CreateMap<Sca.Data.Entities.CertificationProcedurePublication, Sca.Domain.Models.CertificationProcedurePublicationReadModel>();
            CreateMap<Sca.Domain.Models.CertificationProcedurePublicationCreateModel, Sca.Data.Entities.CertificationProcedurePublication>();
            CreateMap<Sca.Domain.Models.CertificationProcedurePublicationUpdateModel, Sca.Data.Entities.CertificationProcedurePublication>();
        }

    }
}
