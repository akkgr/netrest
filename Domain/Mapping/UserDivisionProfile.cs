using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UserDivisionProfile
        : AutoMapper.Profile
    {
        public UserDivisionProfile()
        {
            CreateMap<Sca.Data.Entities.UserDivision, Sca.Domain.Models.UserDivisionReadModel>();
            CreateMap<Sca.Domain.Models.UserDivisionCreateModel, Sca.Data.Entities.UserDivision>();
            CreateMap<Sca.Domain.Models.UserDivisionUpdateModel, Sca.Data.Entities.UserDivision>();
        }

    }
}
