using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserLoginProfile
        : AutoMapper.Profile
    {
        public UserLoginProfile()
        {
            CreateMap<Sca.Data.Entities.UserLogin, Sca.Domain.Models.UserLoginReadModel>();
            CreateMap<Sca.Domain.Models.UserLoginCreateModel, Sca.Data.Entities.UserLogin>();
            CreateMap<Sca.Domain.Models.UserLoginUpdateModel, Sca.Data.Entities.UserLogin>();
        }

    }
}
