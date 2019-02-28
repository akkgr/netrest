using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AutoHistoryProfile
        : AutoMapper.Profile
    {
        public AutoHistoryProfile()
        {
            CreateMap<Sca.Data.Entities.AutoHistory, Sca.Domain.Models.AutoHistoryReadModel>();
            CreateMap<Sca.Domain.Models.AutoHistoryCreateModel, Sca.Data.Entities.AutoHistory>();
            CreateMap<Sca.Domain.Models.AutoHistoryUpdateModel, Sca.Data.Entities.AutoHistory>();
        }

    }
}
