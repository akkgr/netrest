using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DiseaseProfile
        : AutoMapper.Profile
    {
        public DiseaseProfile()
        {
            CreateMap<Sca.Data.Entities.Disease, Sca.Domain.Models.DiseaseReadModel>();
            CreateMap<Sca.Domain.Models.DiseaseCreateModel, Sca.Data.Entities.Disease>();
            CreateMap<Sca.Domain.Models.DiseaseUpdateModel, Sca.Data.Entities.Disease>();
        }

    }
}
