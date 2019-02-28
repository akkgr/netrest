using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class BoardMinuteProfile
        : AutoMapper.Profile
    {
        public BoardMinuteProfile()
        {
            CreateMap<Sca.Data.Entities.BoardMinute, Sca.Domain.Models.BoardMinuteReadModel>();
            CreateMap<Sca.Domain.Models.BoardMinuteCreateModel, Sca.Data.Entities.BoardMinute>();
            CreateMap<Sca.Domain.Models.BoardMinuteUpdateModel, Sca.Data.Entities.BoardMinute>();
        }

    }
}
