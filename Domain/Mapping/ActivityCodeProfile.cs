using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class ActivityCodeProfile
        : AutoMapper.Profile
    {
        public ActivityCodeProfile()
        {
            CreateMap<Sca.Data.Entities.ActivityCode, Sca.Domain.Models.ActivityCodeReadModel>();
            CreateMap<Sca.Domain.Models.ActivityCodeCreateModel, Sca.Data.Entities.ActivityCode>();
            CreateMap<Sca.Domain.Models.ActivityCodeUpdateModel, Sca.Data.Entities.ActivityCode>();
        }

    }
}
