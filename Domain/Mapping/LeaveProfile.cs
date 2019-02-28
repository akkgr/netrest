using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class LeaveProfile
        : AutoMapper.Profile
    {
        public LeaveProfile()
        {
            CreateMap<Sca.Data.Entities.Leave, Sca.Domain.Models.LeaveReadModel>();
            CreateMap<Sca.Domain.Models.LeaveCreateModel, Sca.Data.Entities.Leave>();
            CreateMap<Sca.Domain.Models.LeaveUpdateModel, Sca.Data.Entities.Leave>();
        }

    }
}
