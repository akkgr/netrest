using System;
using AutoMapper;
using Sca.Data.Entities;
using Sca.Domain.Models;

namespace Sca.Domain.Mapping
{
    public partial class AssignmentProfile
        : AutoMapper.Profile
    {
        public AssignmentProfile()
        {
            CreateMap<Sca.Data.Entities.Assignment, Sca.Domain.Models.AssignmentReadModel>();
            CreateMap<Sca.Domain.Models.AssignmentCreateModel, Sca.Data.Entities.Assignment>();
            CreateMap<Sca.Domain.Models.AssignmentUpdateModel, Sca.Data.Entities.Assignment>();
        }

    }
}
