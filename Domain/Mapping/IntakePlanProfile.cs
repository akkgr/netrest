using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class IntakePlanProfile
        : AutoMapper.Profile
    {
        public IntakePlanProfile()
        {
            CreateMap<Sca.Data.Entities.IntakePlan, Sca.Domain.Models.IntakePlanReadModel>();
            CreateMap<Sca.Domain.Models.IntakePlanCreateModel, Sca.Data.Entities.IntakePlan>();
            CreateMap<Sca.Domain.Models.IntakePlanUpdateModel, Sca.Data.Entities.IntakePlan>();
        }

    }
}
