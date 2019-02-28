using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ClientServiceProfile
        : AutoMapper.Profile
    {
        public ClientServiceProfile()
        {
            CreateMap<Sca.Data.Entities.ClientService, Sca.Domain.Models.ClientServiceReadModel>();
            CreateMap<Sca.Domain.Models.ClientServiceCreateModel, Sca.Data.Entities.ClientService>();
            CreateMap<Sca.Domain.Models.ClientServiceUpdateModel, Sca.Data.Entities.ClientService>();
        }

    }
}
