using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CandidateProfile
        : AutoMapper.Profile
    {
        public CandidateProfile()
        {
            CreateMap<Sca.Data.Entities.Candidate, Sca.Domain.Models.CandidateReadModel>();
            CreateMap<Sca.Domain.Models.CandidateCreateModel, Sca.Data.Entities.Candidate>();
            CreateMap<Sca.Domain.Models.CandidateUpdateModel, Sca.Data.Entities.Candidate>();
        }

    }
}
