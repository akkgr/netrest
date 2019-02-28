using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class RoleProfile
        : AutoMapper.Profile
    {
        public RoleProfile()
        {
            CreateMap<Sca.Data.Entities.Role, Sca.Domain.Models.RoleReadModel>();
            CreateMap<Sca.Domain.Models.RoleCreateModel, Sca.Data.Entities.Role>();
            CreateMap<Sca.Domain.Models.RoleUpdateModel, Sca.Data.Entities.Role>();
        }

    }
}
