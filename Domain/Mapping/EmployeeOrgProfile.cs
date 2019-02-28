using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EmployeeOrgProfile
        : AutoMapper.Profile
    {
        public EmployeeOrgProfile()
        {
            CreateMap<Sca.Data.Entities.EmployeeOrg, Sca.Domain.Models.EmployeeOrgReadModel>();
            CreateMap<Sca.Domain.Models.EmployeeOrgCreateModel, Sca.Data.Entities.EmployeeOrg>();
            CreateMap<Sca.Domain.Models.EmployeeOrgUpdateModel, Sca.Data.Entities.EmployeeOrg>();
        }

    }
}
