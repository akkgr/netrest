using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class DivisionJobProfile
        : AutoMapper.Profile
    {
        public DivisionJobProfile()
        {
            CreateMap<Sca.Data.Entities.DivisionJob, Sca.Domain.Models.DivisionJobReadModel>();
            CreateMap<Sca.Domain.Models.DivisionJobCreateModel, Sca.Data.Entities.DivisionJob>();
            CreateMap<Sca.Domain.Models.DivisionJobUpdateModel, Sca.Data.Entities.DivisionJob>();
        }

    }
}
