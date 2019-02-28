using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class WorkingHourProfile
        : AutoMapper.Profile
    {
        public WorkingHourProfile()
        {
            CreateMap<Sca.Data.Entities.WorkingHour, Sca.Domain.Models.WorkingHourReadModel>();
            CreateMap<Sca.Domain.Models.WorkingHourCreateModel, Sca.Data.Entities.WorkingHour>();
            CreateMap<Sca.Domain.Models.WorkingHourUpdateModel, Sca.Data.Entities.WorkingHour>();
        }

    }
}
