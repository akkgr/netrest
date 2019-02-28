using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ClientHistoryServiceProfile
        : AutoMapper.Profile
    {
        public ClientHistoryServiceProfile()
        {
            CreateMap<Sca.Data.Entities.ClientHistoryService, Sca.Domain.Models.ClientHistoryServiceReadModel>();
            CreateMap<Sca.Domain.Models.ClientHistoryServiceCreateModel, Sca.Data.Entities.ClientHistoryService>();
            CreateMap<Sca.Domain.Models.ClientHistoryServiceUpdateModel, Sca.Data.Entities.ClientHistoryService>();
        }

    }
}
