using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class UnitProfile
        : AutoMapper.Profile
    {
        public UnitProfile()
        {
            CreateMap<Sca.Data.Entities.Unit, Sca.Domain.Models.UnitReadModel>();
            CreateMap<Sca.Domain.Models.UnitCreateModel, Sca.Data.Entities.Unit>();
            CreateMap<Sca.Domain.Models.UnitUpdateModel, Sca.Data.Entities.Unit>();
        }

    }
}
