using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserRoleProfile
        : AutoMapper.Profile
    {
        public UserRoleProfile()
        {
            CreateMap<Sca.Data.Entities.UserRole, Sca.Domain.Models.UserRoleReadModel>();
            CreateMap<Sca.Domain.Models.UserRoleCreateModel, Sca.Data.Entities.UserRole>();
            CreateMap<Sca.Domain.Models.UserRoleUpdateModel, Sca.Data.Entities.UserRole>();
        }

    }
}
