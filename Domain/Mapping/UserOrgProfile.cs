using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserOrgProfile
        : AutoMapper.Profile
    {
        public UserOrgProfile()
        {
            CreateMap<Sca.Data.Entities.UserOrg, Sca.Domain.Models.UserOrgReadModel>();
            CreateMap<Sca.Domain.Models.UserOrgCreateModel, Sca.Data.Entities.UserOrg>();
            CreateMap<Sca.Domain.Models.UserOrgUpdateModel, Sca.Data.Entities.UserOrg>();
        }

    }
}
