using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class WorkPositionProfile
        : AutoMapper.Profile
    {
        public WorkPositionProfile()
        {
            CreateMap<Sca.Data.Entities.WorkPosition, Sca.Domain.Models.WorkPositionReadModel>();
            CreateMap<Sca.Domain.Models.WorkPositionCreateModel, Sca.Data.Entities.WorkPosition>();
            CreateMap<Sca.Domain.Models.WorkPositionUpdateModel, Sca.Data.Entities.WorkPosition>();
        }

    }
}
