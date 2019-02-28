using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class EducationProfile
        : AutoMapper.Profile
    {
        public EducationProfile()
        {
            CreateMap<Sca.Data.Entities.Education, Sca.Domain.Models.EducationReadModel>();
            CreateMap<Sca.Domain.Models.EducationCreateModel, Sca.Data.Entities.Education>();
            CreateMap<Sca.Domain.Models.EducationUpdateModel, Sca.Data.Entities.Education>();
        }

    }
}
