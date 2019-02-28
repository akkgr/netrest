using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ClientProfile
        : AutoMapper.Profile
    {
        public ClientProfile()
        {
            CreateMap<Sca.Data.Entities.Client, Sca.Domain.Models.ClientReadModel>();
            CreateMap<Sca.Domain.Models.ClientCreateModel, Sca.Data.Entities.Client>();
            CreateMap<Sca.Domain.Models.ClientUpdateModel, Sca.Data.Entities.Client>();
        }

    }
}
