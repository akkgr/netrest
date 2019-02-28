using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EmploymentTypeProfile
        : AutoMapper.Profile
    {
        public EmploymentTypeProfile()
        {
            CreateMap<Sca.Data.Entities.EmploymentType, Sca.Domain.Models.EmploymentTypeReadModel>();
            CreateMap<Sca.Domain.Models.EmploymentTypeCreateModel, Sca.Data.Entities.EmploymentType>();
            CreateMap<Sca.Domain.Models.EmploymentTypeUpdateModel, Sca.Data.Entities.EmploymentType>();
        }

    }
}
