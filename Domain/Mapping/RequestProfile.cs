using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class RequestProfile
        : AutoMapper.Profile
    {
        public RequestProfile()
        {
            CreateMap<Sca.Data.Entities.Request, Sca.Domain.Models.RequestReadModel>();
            CreateMap<Sca.Domain.Models.RequestCreateModel, Sca.Data.Entities.Request>();
            CreateMap<Sca.Domain.Models.RequestUpdateModel, Sca.Data.Entities.Request>();
        }

    }
}
