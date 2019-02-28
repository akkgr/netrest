using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ReferralLevelProfile
        : AutoMapper.Profile
    {
        public ReferralLevelProfile()
        {
            CreateMap<Sca.Data.Entities.ReferralLevel, Sca.Domain.Models.ReferralLevelReadModel>();
            CreateMap<Sca.Domain.Models.ReferralLevelCreateModel, Sca.Data.Entities.ReferralLevel>();
            CreateMap<Sca.Domain.Models.ReferralLevelUpdateModel, Sca.Data.Entities.ReferralLevel>();
        }

    }
}
