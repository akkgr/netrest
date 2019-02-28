using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DepartmentProfile
        : AutoMapper.Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Sca.Data.Entities.Department, Sca.Domain.Models.DepartmentReadModel>();
            CreateMap<Sca.Domain.Models.DepartmentCreateModel, Sca.Data.Entities.Department>();
            CreateMap<Sca.Domain.Models.DepartmentUpdateModel, Sca.Data.Entities.Department>();
        }

    }
}
