using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CardIntakeProfile
        : AutoMapper.Profile
    {
        public CardIntakeProfile()
        {
            CreateMap<Sca.Data.Entities.CardIntake, Sca.Domain.Models.CardIntakeReadModel>();
            CreateMap<Sca.Domain.Models.CardIntakeCreateModel, Sca.Data.Entities.CardIntake>();
            CreateMap<Sca.Domain.Models.CardIntakeUpdateModel, Sca.Data.Entities.CardIntake>();
        }

    }
}
