using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ParameterProfile
        : AutoMapper.Profile
    {
        public ParameterProfile()
        {
            CreateMap<Sca.Data.Entities.Parameter, Sca.Domain.Models.ParameterReadModel>();
            CreateMap<Sca.Domain.Models.ParameterCreateModel, Sca.Data.Entities.Parameter>();
            CreateMap<Sca.Domain.Models.ParameterUpdateModel, Sca.Data.Entities.Parameter>();
        }

    }
}
