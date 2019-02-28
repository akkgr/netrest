using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ReferralProfile
        : AutoMapper.Profile
    {
        public ReferralProfile()
        {
            CreateMap<Sca.Data.Entities.Referral, Sca.Domain.Models.ReferralReadModel>();
            CreateMap<Sca.Domain.Models.ReferralCreateModel, Sca.Data.Entities.Referral>();
            CreateMap<Sca.Domain.Models.ReferralUpdateModel, Sca.Data.Entities.Referral>();
        }

    }
}
