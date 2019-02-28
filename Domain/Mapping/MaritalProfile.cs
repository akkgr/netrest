using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class MaritalProfile
        : AutoMapper.Profile
    {
        public MaritalProfile()
        {
            CreateMap<Sca.Data.Entities.Marital, Sca.Domain.Models.MaritalReadModel>();
            CreateMap<Sca.Domain.Models.MaritalCreateModel, Sca.Data.Entities.Marital>();
            CreateMap<Sca.Domain.Models.MaritalUpdateModel, Sca.Data.Entities.Marital>();
        }

    }
}
