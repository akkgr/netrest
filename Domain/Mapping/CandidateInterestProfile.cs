using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CandidateInterestProfile
        : AutoMapper.Profile
    {
        public CandidateInterestProfile()
        {
            CreateMap<Sca.Data.Entities.CandidateInterest, Sca.Domain.Models.CandidateInterestReadModel>();
            CreateMap<Sca.Domain.Models.CandidateInterestCreateModel, Sca.Data.Entities.CandidateInterest>();
            CreateMap<Sca.Domain.Models.CandidateInterestUpdateModel, Sca.Data.Entities.CandidateInterest>();
        }

    }
}
