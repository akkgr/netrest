using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EmployeeIntakeProfile
        : AutoMapper.Profile
    {
        public EmployeeIntakeProfile()
        {
            CreateMap<Sca.Data.Entities.EmployeeIntake, Sca.Domain.Models.EmployeeIntakeReadModel>();
            CreateMap<Sca.Domain.Models.EmployeeIntakeCreateModel, Sca.Data.Entities.EmployeeIntake>();
            CreateMap<Sca.Domain.Models.EmployeeIntakeUpdateModel, Sca.Data.Entities.EmployeeIntake>();
        }

    }
}
