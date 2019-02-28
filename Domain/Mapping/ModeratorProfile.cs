using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ModeratorProfile
        : AutoMapper.Profile
    {
        public ModeratorProfile()
        {
            CreateMap<Sca.Data.Entities.Moderator, Sca.Domain.Models.ModeratorReadModel>();
            CreateMap<Sca.Domain.Models.ModeratorCreateModel, Sca.Data.Entities.Moderator>();
            CreateMap<Sca.Domain.Models.ModeratorUpdateModel, Sca.Data.Entities.Moderator>();
        }

    }
}
