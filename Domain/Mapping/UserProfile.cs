using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserProfile
        : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Sca.Data.Entities.User, Sca.Domain.Models.UserReadModel>();
            CreateMap<Sca.Domain.Models.UserCreateModel, Sca.Data.Entities.User>();
            CreateMap<Sca.Domain.Models.UserUpdateModel, Sca.Data.Entities.User>();
        }

    }
}
