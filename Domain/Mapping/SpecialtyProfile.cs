using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class SpecialtyProfile
        : AutoMapper.Profile
    {
        public SpecialtyProfile()
        {
            CreateMap<Sca.Data.Entities.Specialty, Sca.Domain.Models.SpecialtyReadModel>();
            CreateMap<Sca.Domain.Models.SpecialtyCreateModel, Sca.Data.Entities.Specialty>();
            CreateMap<Sca.Domain.Models.SpecialtyUpdateModel, Sca.Data.Entities.Specialty>();
        }

    }
}
