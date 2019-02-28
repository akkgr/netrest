using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ClientHistoryProfile
        : AutoMapper.Profile
    {
        public ClientHistoryProfile()
        {
            CreateMap<Sca.Data.Entities.ClientHistory, Sca.Domain.Models.ClientHistoryReadModel>();
            CreateMap<Sca.Domain.Models.ClientHistoryCreateModel, Sca.Data.Entities.ClientHistory>();
            CreateMap<Sca.Domain.Models.ClientHistoryUpdateModel, Sca.Data.Entities.ClientHistory>();
        }

    }
}
