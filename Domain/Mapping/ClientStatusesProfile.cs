using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ClientStatusesProfile
        : AutoMapper.Profile
    {
        public ClientStatusesProfile()
        {
            CreateMap<Sca.Data.Entities.ClientStatuses, Sca.Domain.Models.ClientStatusesReadModel>();
            CreateMap<Sca.Domain.Models.ClientStatusesCreateModel, Sca.Data.Entities.ClientStatuses>();
            CreateMap<Sca.Domain.Models.ClientStatusesUpdateModel, Sca.Data.Entities.ClientStatuses>();
        }

    }
}
