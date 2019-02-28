using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class RequestTypeProfile
        : AutoMapper.Profile
    {
        public RequestTypeProfile()
        {
            CreateMap<Sca.Data.Entities.RequestType, Sca.Domain.Models.RequestTypeReadModel>();
            CreateMap<Sca.Domain.Models.RequestTypeCreateModel, Sca.Data.Entities.RequestType>();
            CreateMap<Sca.Domain.Models.RequestTypeUpdateModel, Sca.Data.Entities.RequestType>();
        }

    }
}
