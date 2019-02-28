using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ParticipantProfile
        : AutoMapper.Profile
    {
        public ParticipantProfile()
        {
            CreateMap<Sca.Data.Entities.Participant, Sca.Domain.Models.ParticipantReadModel>();
            CreateMap<Sca.Domain.Models.ParticipantCreateModel, Sca.Data.Entities.Participant>();
            CreateMap<Sca.Domain.Models.ParticipantUpdateModel, Sca.Data.Entities.Participant>();
        }

    }
}
