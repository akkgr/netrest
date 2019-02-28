using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class IntakeBenefitProfile
        : AutoMapper.Profile
    {
        public IntakeBenefitProfile()
        {
            CreateMap<Sca.Data.Entities.IntakeBenefit, Sca.Domain.Models.IntakeBenefitReadModel>();
            CreateMap<Sca.Domain.Models.IntakeBenefitCreateModel, Sca.Data.Entities.IntakeBenefit>();
            CreateMap<Sca.Domain.Models.IntakeBenefitUpdateModel, Sca.Data.Entities.IntakeBenefit>();
        }

    }
}
