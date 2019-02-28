using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserClaimProfile
        : AutoMapper.Profile
    {
        public UserClaimProfile()
        {
            CreateMap<Sca.Data.Entities.UserClaim, Sca.Domain.Models.UserClaimReadModel>();
            CreateMap<Sca.Domain.Models.UserClaimCreateModel, Sca.Data.Entities.UserClaim>();
            CreateMap<Sca.Domain.Models.UserClaimUpdateModel, Sca.Data.Entities.UserClaim>();
        }

    }
}
