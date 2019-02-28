using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DivisionProfile
        : AutoMapper.Profile
    {
        public DivisionProfile()
        {
            CreateMap<Sca.Data.Entities.Division, Sca.Domain.Models.DivisionReadModel>();
            CreateMap<Sca.Domain.Models.DivisionCreateModel, Sca.Data.Entities.Division>();
            CreateMap<Sca.Domain.Models.DivisionUpdateModel, Sca.Data.Entities.Division>();
        }

    }
}
