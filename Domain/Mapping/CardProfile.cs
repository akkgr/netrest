using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class CardProfile
        : AutoMapper.Profile
    {
        public CardProfile()
        {
            CreateMap<Sca.Data.Entities.Card, Sca.Domain.Models.CardReadModel>();
            CreateMap<Sca.Domain.Models.CardCreateModel, Sca.Data.Entities.Card>();
            CreateMap<Sca.Domain.Models.CardUpdateModel, Sca.Data.Entities.Card>();
        }

    }
}
