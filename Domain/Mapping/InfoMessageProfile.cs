using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class InfoMessageProfile
        : AutoMapper.Profile
    {
        public InfoMessageProfile()
        {
            CreateMap<Sca.Data.Entities.InfoMessage, Sca.Domain.Models.InfoMessageReadModel>();
            CreateMap<Sca.Domain.Models.InfoMessageCreateModel, Sca.Data.Entities.InfoMessage>();
            CreateMap<Sca.Domain.Models.InfoMessageUpdateModel, Sca.Data.Entities.InfoMessage>();
        }

    }
}
