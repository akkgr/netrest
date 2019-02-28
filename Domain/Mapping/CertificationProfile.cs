using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CertificationProfile
        : AutoMapper.Profile
    {
        public CertificationProfile()
        {
            CreateMap<Sca.Data.Entities.Certification, Sca.Domain.Models.CertificationReadModel>();
            CreateMap<Sca.Domain.Models.CertificationCreateModel, Sca.Data.Entities.Certification>();
            CreateMap<Sca.Domain.Models.CertificationUpdateModel, Sca.Data.Entities.Certification>();
        }

    }
}
