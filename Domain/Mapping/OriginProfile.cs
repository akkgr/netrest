using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class OriginProfile
        : AutoMapper.Profile
    {
        public OriginProfile()
        {
            CreateMap<Sca.Data.Entities.Origin, Sca.Domain.Models.OriginReadModel>();
            CreateMap<Sca.Domain.Models.OriginCreateModel, Sca.Data.Entities.Origin>();
            CreateMap<Sca.Domain.Models.OriginUpdateModel, Sca.Data.Entities.Origin>();
        }

    }
}
