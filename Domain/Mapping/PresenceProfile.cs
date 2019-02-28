using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class PresenceProfile
        : AutoMapper.Profile
    {
        public PresenceProfile()
        {
            CreateMap<Sca.Data.Entities.Presence, Sca.Domain.Models.PresenceReadModel>();
            CreateMap<Sca.Domain.Models.PresenceCreateModel, Sca.Data.Entities.Presence>();
            CreateMap<Sca.Domain.Models.PresenceUpdateModel, Sca.Data.Entities.Presence>();
        }

    }
}
