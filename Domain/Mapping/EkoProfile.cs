using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EkoProfile
        : AutoMapper.Profile
    {
        public EkoProfile()
        {
            CreateMap<Sca.Data.Entities.Eko, Sca.Domain.Models.EkoReadModel>();
            CreateMap<Sca.Domain.Models.EkoCreateModel, Sca.Data.Entities.Eko>();
            CreateMap<Sca.Domain.Models.EkoUpdateModel, Sca.Data.Entities.Eko>();
        }

    }
}
