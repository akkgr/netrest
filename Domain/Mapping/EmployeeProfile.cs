using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EmployeeProfile
        : AutoMapper.Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Sca.Data.Entities.Employee, Sca.Domain.Models.EmployeeReadModel>();
            CreateMap<Sca.Domain.Models.EmployeeCreateModel, Sca.Data.Entities.Employee>();
            CreateMap<Sca.Domain.Models.EmployeeUpdateModel, Sca.Data.Entities.Employee>();
        }

    }
}
