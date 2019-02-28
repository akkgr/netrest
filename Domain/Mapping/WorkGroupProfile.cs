using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class WorkGroupProfile
        : AutoMapper.Profile
    {
        public WorkGroupProfile()
        {
            CreateMap<Sca.Data.Entities.WorkGroup, Sca.Domain.Models.WorkGroupReadModel>();
            CreateMap<Sca.Domain.Models.WorkGroupCreateModel, Sca.Data.Entities.WorkGroup>();
            CreateMap<Sca.Domain.Models.WorkGroupUpdateModel, Sca.Data.Entities.WorkGroup>();
        }

    }
}
