using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class WorkGroupTypeProfile
        : AutoMapper.Profile
    {
        public WorkGroupTypeProfile()
        {
            CreateMap<Sca.Data.Entities.WorkGroupType, Sca.Domain.Models.WorkGroupTypeReadModel>();
            CreateMap<Sca.Domain.Models.WorkGroupTypeCreateModel, Sca.Data.Entities.WorkGroupType>();
            CreateMap<Sca.Domain.Models.WorkGroupTypeUpdateModel, Sca.Data.Entities.WorkGroupType>();
        }

    }
}
