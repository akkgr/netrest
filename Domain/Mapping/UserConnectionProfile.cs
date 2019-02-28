using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserConnectionProfile
        : AutoMapper.Profile
    {
        public UserConnectionProfile()
        {
            CreateMap<Sca.Data.Entities.UserConnection, Sca.Domain.Models.UserConnectionReadModel>();
            CreateMap<Sca.Domain.Models.UserConnectionCreateModel, Sca.Data.Entities.UserConnection>();
            CreateMap<Sca.Domain.Models.UserConnectionUpdateModel, Sca.Data.Entities.UserConnection>();
        }

    }
}
