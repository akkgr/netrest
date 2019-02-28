using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CardTypeProfile
        : AutoMapper.Profile
    {
        public CardTypeProfile()
        {
            CreateMap<Sca.Data.Entities.CardType, Sca.Domain.Models.CardTypeReadModel>();
            CreateMap<Sca.Domain.Models.CardTypeCreateModel, Sca.Data.Entities.CardType>();
            CreateMap<Sca.Domain.Models.CardTypeUpdateModel, Sca.Data.Entities.CardType>();
        }

    }
}
