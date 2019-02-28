using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CardClientProfile
        : AutoMapper.Profile
    {
        public CardClientProfile()
        {
            CreateMap<Sca.Data.Entities.CardClient, Sca.Domain.Models.CardClientReadModel>();
            CreateMap<Sca.Domain.Models.CardClientCreateModel, Sca.Data.Entities.CardClient>();
            CreateMap<Sca.Domain.Models.CardClientUpdateModel, Sca.Data.Entities.CardClient>();
        }

    }
}
