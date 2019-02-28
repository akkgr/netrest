using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DepartmentDivisionProfile
        : AutoMapper.Profile
    {
        public DepartmentDivisionProfile()
        {
            CreateMap<Sca.Data.Entities.DepartmentDivision, Sca.Domain.Models.DepartmentDivisionReadModel>();
            CreateMap<Sca.Domain.Models.DepartmentDivisionCreateModel, Sca.Data.Entities.DepartmentDivision>();
            CreateMap<Sca.Domain.Models.DepartmentDivisionUpdateModel, Sca.Data.Entities.DepartmentDivision>();
        }

    }
}
