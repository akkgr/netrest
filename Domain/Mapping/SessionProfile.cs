using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class SessionProfile
        : AutoMapper.Profile
    {
        public SessionProfile()
        {
            CreateMap<Sca.Data.Entities.Session, Sca.Domain.Models.SessionReadModel>();
            CreateMap<Sca.Domain.Models.SessionCreateModel, Sca.Data.Entities.Session>();
            CreateMap<Sca.Domain.Models.SessionUpdateModel, Sca.Data.Entities.Session>();
        }

    }
}
