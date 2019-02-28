using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DepartmentUserProfile
        : AutoMapper.Profile
    {
        public DepartmentUserProfile()
        {
            CreateMap<Sca.Data.Entities.DepartmentUser, Sca.Domain.Models.DepartmentUserReadModel>();
            CreateMap<Sca.Domain.Models.DepartmentUserCreateModel, Sca.Data.Entities.DepartmentUser>();
            CreateMap<Sca.Domain.Models.DepartmentUserUpdateModel, Sca.Data.Entities.DepartmentUser>();
        }

    }
}
