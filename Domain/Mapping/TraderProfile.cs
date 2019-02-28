using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class TraderProfile
        : AutoMapper.Profile
    {
        public TraderProfile()
        {
            CreateMap<Sca.Data.Entities.Trader, Sca.Domain.Models.TraderReadModel>();
            CreateMap<Sca.Domain.Models.TraderCreateModel, Sca.Data.Entities.Trader>();
            CreateMap<Sca.Domain.Models.TraderUpdateModel, Sca.Data.Entities.Trader>();
        }

    }
}
