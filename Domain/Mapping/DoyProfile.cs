using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DoyProfile
        : AutoMapper.Profile
    {
        public DoyProfile()
        {
            CreateMap<Sca.Data.Entities.Doy, Sca.Domain.Models.DoyReadModel>();
            CreateMap<Sca.Domain.Models.DoyCreateModel, Sca.Data.Entities.Doy>();
            CreateMap<Sca.Domain.Models.DoyUpdateModel, Sca.Data.Entities.Doy>();
        }

    }
}
