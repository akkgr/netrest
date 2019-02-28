using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DepartmentCertificationProfile
        : AutoMapper.Profile
    {
        public DepartmentCertificationProfile()
        {
            CreateMap<Sca.Data.Entities.DepartmentCertification, Sca.Domain.Models.DepartmentCertificationReadModel>();
            CreateMap<Sca.Domain.Models.DepartmentCertificationCreateModel, Sca.Data.Entities.DepartmentCertification>();
            CreateMap<Sca.Domain.Models.DepartmentCertificationUpdateModel, Sca.Data.Entities.DepartmentCertification>();
        }

    }
}
